using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TMS.Models;
using TMS.Repositories;
using TMS.ViewModels;

namespace TMS.Controllers
{
    
    public class EmployeeController : Controller
    {

        private readonly IEmployeeRepository _iEmployeeRepository;
        private readonly CompetenciesController CC = new CompetenciesController();
        private readonly EmployeeCompetencyController ECC = new EmployeeCompetencyController();



        public EmployeeController(IEmployeeRepository iEmployeeRepository)
        {
            _iEmployeeRepository = iEmployeeRepository;
        }

        // this is used to display list of all employees when you click employee on the menu
        // GET: People
        public ActionResult Index()
        {
            // this is never used
            var employees = _iEmployeeRepository.All.ToList();

            if (true)
            // this is allways run (i think Dana did the if to test 2 different solutions)
            {
                //generates a  EmployeeIndexViewModel(found under ViewModels folder) with the 3 below parameters 
                var eivm = new EmployeeIndexViewModel
                {
                    //Employees is a ICollection (list) 
                    //Employees is set by calling the All of the EmployeeRepository (found in Repositories folder)
                    // it is a list of all employees
                    Employees = _iEmployeeRepository.All.ToList(),
                    //Competencies is ICollection (list)
                    //Competencies is set by calling the All of the CompetenciesController (found in the Controllers folder)
                    // it is a list of all Competencies
                    Competencies = CC.All.ToList(),
                    //Employees_Competency is a ICollection (list)
                    //Employees_Competency is set by calling the all of the EmployeeCompetencyController (found in the controllers folder)
                    // it is a list of (id, employeeid, competencyid) so a list of the employees competencies
                    Employees_Competency = ECC.All.ToList()
                };
                //return the EmployeeIndexViewModel to the view
                return View(eivm);
            }
            else
            //this is never used
            {
                
                Employee person = new Employee();
                List<Employee_Competency> ecList = new List<Employee_Competency>();
                List<Competency> compList = new List<Competency>();

                localhostEmployee.EmployeeWebserviceService EWS = new localhostEmployee.EmployeeWebserviceService();
                localhostEC.EmployeeCompetencyWebserviceService ECWS = new localhostEC.EmployeeCompetencyWebserviceService();
                localhostCompetency.CompetencyWebserviceService CWS = new localhostCompetency.CompetencyWebserviceService();

                localhostEmployee.Employee[] muffin = EWS.getAllEmployees();
                localhostEC.EmployeeCompetency[] pancake = ECWS.findAllEmployeeCompetencies(person.Id);
                localhostCompetency.Competency[] cake = CWS.getAllCompetencies();

                ECWS.Timeout = 2000;
                CWS.Timeout = 2000;

                Employee_Competency ec;
                Competency competency;

                foreach (localhostEC.EmployeeCompetency comp in pancake)
                {
                    ec = new Employee_Competency();
                    ec.setEmployeeCompetency(comp);
                    ecList.Add(ec);


                    foreach (localhostCompetency.Competency compot in cake)
                    {

                        if (compot.id == ec.competencyId)
                        {
                            competency = new Competency();
                            competency.setCompetency(compot);
                            compList.Add(competency);
                        }

                    }
                }
                var vm = new EmployeeIndexViewModel
                {
                    Employee = person,
                    Competencies = compList

                };
                return View(vm);
            }
        }

        // GET: People/Details/5
        // this is called when the details of a Employee is chosen
        //it is called with the id of the customer
        //the ? means tha we accept a id = null
        public ActionResult Details(int? id)
        {
            //if the id is null
            if (id == null)
            {
                //we return a badrequest webpager
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //create an employee called person by calling the Find of the EmployeeRepository with an id
            Employee person = _iEmployeeRepository.Find(id);

            //if the person is null = not found then return not found webpage
            if (person == null)
            {
                return HttpNotFound();
            }
            else
            {
                //create an empty list of Employee_Competencies called ecList
                List<Employee_Competency> ecList = new List<Employee_Competency>();
                //create an empty list of Competencies called compList
                List<Competency> compList = new List<Competency>();

                //generate an instance of EmployeeCompetencyWebserviceService called ECWS to be able to call the webservice
                localhostEC.EmployeeCompetencyWebserviceService ECWS = new localhostEC.EmployeeCompetencyWebserviceService();
                //generate an instance of CompetencyWebserviceService called ECWS to be able to call the webservice
                localhostCompetency.CompetencyWebserviceService CWS = new localhostCompetency.CompetencyWebserviceService();

                //generate an array of EmployeeCompetency datatype called pancake from the webservice 
                //fill it by calling the function findAllEmployeeCompetencies of the EmployeeCompetencyWebserviceService with the id of the employee (person)
                //the datatypes used in the webservice is available here by using the reference (localhost...)
                localhostEC.EmployeeCompetency[] pancake = ECWS.findAllEmployeeCompetencies(person.Id);
                //generate an array of Competency datatype called cake from the webservice 
                //fill it by calling the function getAllCompetencies of the CompetencyWebserviceService
                localhostCompetency.Competency[] cake = CWS.getAllCompetencies();

                //set the timout of calls to the webservices (this was a try to stop the problem with the connection closing)
                ECWS.Timeout = 2000;
                CWS.Timeout = 2000;

                // create an empty Employee_competency (from the Models)
                Employee_Competency ec;
                // create an empty Employee_competency (from the Models)
                Competency competency;

                //for each EmployeeCompetency found from the webservice call (so all the competencies for this employee
                foreach (localhostEC.EmployeeCompetency comp in pancake)
                {
                    //set the ec to a new instance
                    ec = new Employee_Competency();
                    //call the setEmployeeCompetency of the Employee_competency to translate the webservice datatype to the Models datatype.
                    ec.setEmployeeCompetency(comp);
                    // add the instance to the list ecList
                    ecList.Add(ec);

                    //for each Competency gotten from the webservice call (so an array of the competencies)
                    foreach (localhostCompetency.Competency compot in cake)
                    {

                        //if the id of the competency from the list of competencies == id of the the competency from the employees competencies
                        if (compot.id == ec.competencyId)
                        {
                            //set competency to a new instance
                            competency = new Competency();
                            //call the setCompetency of the Competency to translate the webservice datatype to the Models datatype
                            competency.setCompetency(compot);
                            //add the instance to the list compList
                            compList.Add(competency);
                        }

                    }
                }
                //create an instance of EmployeeIndexViewModel with the 2 below parameters
                var vm = new EmployeeIndexViewModel
                {
                    //Employee the data of the employee
                    Employee = person,
                    //Competencies the list of competencies
                    Competencies = compList

                };
                //return the EmployeeIndexViewModel to the view
                return View(vm);
            }
        }

        // GET: People/Create
        // this is called when the create of a Employee is chosen
        public ActionResult Create()
        {
            //Create a list of Competency
            List<Competency> compList = new List<Competency>();

            //create an instance of the CompetencyWebserviceService to be able to call the webservice
            localhostCompetency.CompetencyWebserviceService CWS = new localhostCompetency.CompetencyWebserviceService();
            //call the webservice function getAllCompetencies to get an array of the competencies
            localhostCompetency.Competency[] cake = CWS.getAllCompetencies();
            // to try to solve disconnect problem
            CWS.Timeout = 2000;

            
            Competency competency;
            // for each Competency in the array of competencies gotten from the webservice
            foreach (localhostCompetency.Competency comp in cake)
            {
                //create a new instance of the Competency
                competency = new Competency();
                //call setCompetency to translate the webservice Competency datatype to Model Competency datatype
                competency.setCompetency(comp);
                // add to list
                compList.Add(competency);
            }

            //create a new instance of EmployeeCompetencyViewModel with 2 params
            var ecvm = new EmployeeCompetencyViewModel
            {
                // a new empty instance of Employee
                Employee = new Employee(),
                // the list of possible competencies
                Competencies = compList
            };
            //return the EmployeeCompetencyViewModel to the view
            return View(ecvm);
        }

        // POST: People/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //This means we are listening for a post
        [HttpPost]
        [ValidateAntiForgeryToken]
        // this is called when save is clicked on the create page
        //the data and compIds are recieved via the post (they can be seen in the EmployeeCompetencyViewModel in the folder shared
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,Email,Phone,BirthDate,HomeAddress,Competencies,")] Employee person,
            EmployeeCompetencyViewModel data, IEnumerable<int> compIds)
        {
            //if all the data is correct
            if (ModelState.IsValid)
            {
                //call the InsertOrUpdate of the EmployeeRepository to create the Employee
                _iEmployeeRepository.InsertOrUpdate(data.Employee);

                // if there are any copIds (id's of competencies) 
                if (compIds != null)
                {
                    //for each competency id
                    foreach (var pancake in compIds)
                    {
                        //create an instance of with the 2 params below
                        var employeeCompetency = new Employee_Competency
                        {
                            //the competency id chosen in the create
                            competencyId = pancake,
                            //the id of the employee
                            employeeId = data.Employee.Id
                        };
                        //Call the Create of the EmployeeCompetencyController to create the employeecompetency
                        ECC.Create(employeeCompetency);
                    }
                }
                //return to the Employee index page
                return RedirectToAction("Index");
            }
            //if the model state is invalid that means there has been error on the create page
            //create data to put to the Create again same as in the Create()
            List<Competency> compList = new List<Competency>();

            localhostCompetency.CompetencyWebserviceService CWS = new localhostCompetency.CompetencyWebserviceService();
            localhostCompetency.Competency[] cake = CWS.getAllCompetencies();
            CWS.Timeout = 2000;

            Competency competency;
            foreach (localhostCompetency.Competency comp in cake)
            {
                competency = new Competency();
                competency.setCompetency(comp);
                compList.Add(competency);
            }

            var ecvm = new EmployeeCompetencyViewModel
            {
                Employee = person,
                Competencies = compList
            };
            return View(ecvm);
        }

        // GET: People/Edit/5
        // this is called when the edit of a Employee is chosen
        // it gets the id of the employee that needs to be editted
        public ActionResult Edit(int? id)
        {
            // as above 
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            // call the EmployeeRepository (from the Repository folder) to get the Employee
            var employee = _iEmployeeRepository.Find(id);
            //create a list
            List<Competency> compList = new List<Competency>();
            //create a link to webservice
            localhostCompetency.CompetencyWebserviceService CWS = new localhostCompetency.CompetencyWebserviceService();
            //call the getAllCompetencies of the competency webservice to get a list of possible competencies
            localhostCompetency.Competency[] pancake = CWS.getAllCompetencies();
            //set timeout
            CWS.Timeout = 2000;

            Competency competency;
            //go throug each Competency from the webservice translate them into ASP Model and add to list
            foreach (localhostCompetency.Competency comp in pancake)
            {
                competency = new Competency();
                competency.setCompetency(comp);
                compList.Add(competency);
            }
            //Create EmployeeCompetencyViewModel with the 2 parm below
            var vm = new EmployeeCompetencyViewModel
            {
                Employee = employee,
                Competencies = compList
            };
            //return the EmployeeCompetencyViewModel
            return View(vm);
        }

        // POST: People/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //like create this is a post
        [HttpPost]
        [ValidateAntiForgeryToken]
        // this is called when the save of the edit is chosen
        //the data and compIds are recieved via the post (they can be seen in the EmployeeCompetencyViewModel in the folder shared
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,Email,Phone,BirthDate,HomeAddress,Competencies")] Employee person,
            EmployeeCompetencyViewModel data, IEnumerable<int> compIds)
        {
            //if the inputted data is valid
            if (ModelState.IsValid)

            {
                //call the InsertOrUpdate of the EmployeeRepository to update the customer part
                _iEmployeeRepository.InsertOrUpdate(data.Employee);

                //if there are any competencies chosen
                if (compIds != null)
                {
                    foreach (var pancake in compIds)
                    {
                        //create an employeeCompetency with the chosen employee and the chosen competency
                        var employeeCompetency = new Employee_Competency
                        {
                            competencyId = pancake,
                            employeeId = data.Employee.Id
                        };
                        //call the create of the EmployeeCompetency controller to create the employeecompetency via webservice
                        //all the existing employeecompetencies should have been deleted first
                        ECC.Create(employeeCompetency);
                    }
                }
                //If no competencies are chosen
                else
                {
                    throw new ArgumentNullException(nameof(compIds),
                        "The competencies can not be NULL, you have to select at least 1.");
                }
                return RedirectToAction("Index");
            }

            return View();
        }
        // GET: People/Delete/5
        // this is called when the delete of the index is chosen
        public ActionResult Delete(int? id)
        {
            //if no id it is an error and we return an error page
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //use the Find of the EmployeeRepository to get the employee
            Employee person = _iEmployeeRepository.Find(id);
            //if the employee is not found then its an error
            if (person == null)
            {
                return HttpNotFound();
            }
            else
            {
                //create a EMployeeCompetency list
                List<Employee_Competency> ecList = new List<Employee_Competency>();
                //create a Competency list
                List<Competency> compList = new List<Competency>();

                //create refference to be able to call webservice
                localhostEC.EmployeeCompetencyWebserviceService ECWS = new localhostEC.EmployeeCompetencyWebserviceService();
                localhostCompetency.CompetencyWebserviceService CWS = new localhostCompetency.CompetencyWebserviceService();

                //create an array of EmpoyeeCompetencies belonging to the employee that we wish to delete
                // by calling the findAllEmployeeCompetencies function of the EmployeeCompetencyWebserviceService
                localhostEC.EmployeeCompetency[] pancake = ECWS.findAllEmployeeCompetencies(person.Id);
                //create an array of Competencies by calling the getAllCompetencies function of the CompetencyWebserviceService
                localhostCompetency.Competency[] cake = CWS.getAllCompetencies();

                ECWS.Timeout = 2000;
                CWS.Timeout = 2000;

                Employee_Competency ec;
                Competency competency;

                
                foreach (localhostEC.EmployeeCompetency comp in pancake)
                {
                    ec = new Employee_Competency();
                    //translate the Employeecompetency from webservice datatype to ASP datatype
                    ec.setEmployeeCompetency(comp);
                    ecList.Add(ec);


                    foreach (localhostCompetency.Competency compot in cake)
                    {

                        if (compot.id == ec.competencyId)
                        {
                            competency = new Competency();
                            competency.setCompetency(compot);
                            compList.Add(competency);
                        }

                    }
                }
                var vm = new EmployeeIndexViewModel
                {
                    Employee = person,
                    Competencies = compList

                };
                return View(vm);
            }
        }

        // POST: People/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            //Employee employee = new Employee();
            //create ref to be able to call webservice
            localhostEmployee.EmployeeWebserviceService EWS = new localhostEmployee.EmployeeWebserviceService();
            EWS.Timeout = 2000;
            //set a Employee called delete found by calling the findEmployee function of the EmployeeWebserviceService
            localhostEmployee.Employee delete = EWS.findEmployee((int)id);
            //call the deleteEmployee function of the EmployeeWebserviceService
            //if the competencies are not deleted in the java code, then this will fail
            //because we have to delete Employeecompetencies before we delete the employee
            EWS.deleteEmployee(delete);
           // _iEmployeeRepository.Delete(id);
            return RedirectToAction("Index");
        }

    }
}
