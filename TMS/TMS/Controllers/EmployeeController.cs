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

        private readonly CompetencyRepository _competencyRepository = new CompetencyRepository();
        private readonly IEmployeeRepository _iEmployeeRepository;
        private readonly EmployeeCompetencyRepository _employeeCompetencyRepository = new EmployeeCompetencyRepository();


        public EmployeeController(IEmployeeRepository iEmployeeRepository)
        {
            _iEmployeeRepository = iEmployeeRepository;
        }

        // GET: People
        public ActionResult Index(string search = "")
        {
            var employees = _iEmployeeRepository.All.ToList();

            if (!string.IsNullOrEmpty(search))
            {
                var eivm = new EmployeeIndexViewModel
                {
                    Employees = _iEmployeeRepository.All.Where(a => a.FirstName.Contains(search.ToUpper())).ToList(),
                    Competencies = _competencyRepository.All.ToList(),
                    Employees_Competecy = _employeeCompetencyRepository.All.ToList()
                };
                return View(eivm);
            }
            else
            {
                var eivm = new EmployeeIndexViewModel
                {
                    Employees = _iEmployeeRepository.All.ToList(),
                    Competencies = _competencyRepository.All.ToList(),
                    Employees_Competecy = _employeeCompetencyRepository.All.ToList()
                };
                return View(eivm);
            }
        }

        // GET: People/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee person = _iEmployeeRepository.Find(id);
            if (person == null)
            {
                return HttpNotFound();
            }
            return View(person);
        }

        // GET: People/Create
        public ActionResult Create()
        {
            var ecvm =
               new EmployeeCompetencyViewModel
               {
                   Employee = new Employee(),
                   Competencies = _competencyRepository.AllIncluding(a => a.Employee_Competencies).ToList()
               };
            return View(ecvm);
        }

        // POST: People/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,Email,Phone,BirthDate,HomeAddress,Competencies,Role")] Employee person,
            EmployeeCompetencyViewModel data, IEnumerable<int> compIds)
        {
            if (ModelState.IsValid)
            {
                _iEmployeeRepository.InsertOrUpdate(data.Employee);
                foreach (var pancake in compIds)
                {
                    var employeeCompetency = new Employee_Competency
                    {
                        employeeId = pancake,
                        competencyId = data.Employee.Id
                    };
                    _employeeCompetencyRepository.InsertOrUpdate(employeeCompetency);
                }

                return RedirectToAction("Index");
            }
            var ecvm =
                new EmployeeCompetencyViewModel
                {
                    Employee = new Employee(),
                    Competencies = _competencyRepository.AllIncluding(a => a.Competencies).ToList()
                };


            return View(ecvm);
        }

        // GET: People/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var employee = _iEmployeeRepository.Find(id);
            var vm = new EmployeeCompetencyViewModel
            {
                Employee = employee,
                Competencies = _competencyRepository.AllIncluding(a => a.Competencies).ToList()
            };
            return View(vm);
        }

        // POST: People/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,Email,Phone,BirthDate,HomeAddress,Competencies,Role")] Employee person,
            EmployeeCompetencyViewModel data, IEnumerable<int> compIds)
        {
            if (ModelState.IsValid)

            {
                _iEmployeeRepository.InsertOrUpdate(data.Employee);

                if (compIds != null)
                {
                    foreach (var pancake in compIds)
                    {
                        var employeeCompetency = new Employee_Competency
                        {
                            competencyId = pancake,
                            employeeId = data.Employee.Id
                        };
                        _employeeCompetencyRepository.InsertOrUpdate(employeeCompetency);
                    }
                }
                else //By Dana
                {
                    throw new ArgumentNullException(nameof(compIds),
                        "The competencies can not be NULL, you have to select at least 1.");
                }
                return RedirectToAction("Index");
            }

            return View();
        }
        // GET: People/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee person = _iEmployeeRepository.Find(id);
            if (person == null)
            {
                return HttpNotFound();
            }
            return View(person);
        }

        // POST: People/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            _iEmployeeRepository.Delete(id);
            return RedirectToAction("Index");
        }

    }
}
