using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TMS.Models;

namespace TMS.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }
        // GET: Test
        public ActionResult test3()
        {
            //return View(db.Customers.ToList());
            List<Test> testlist = new List<Test>();

            //localhost.CustomerWebserviceService CWS = new localhost.CustomerWebserviceService();
            //CWS.Timeout = 2000;
            //localhost.Customer[] aaa = CWS.findCustomerArray();

            //Test cust;
            //foreach (localhost.Customer cust2 in aaa)
            //{
            //    cust = new Test();
            //    cust.name = "aaa";
            //    test2.Add(cust);
            //}

            Test test1 = new Test();
            test1.name = "name1";
            //test1.task = new string[16] { "Taks1", "Taks1", "Taks1", "Taks1", "Task2", "Task2", "", "", "", "", "", "", "", "", "", "" };
            testlist.Add(test1);
            Test test2 = new Test();
            test2.name = "name2";
            //test2.task = new string[16] { "Taks1", "Taks1", "Taks1", "Taks1", "Task3", "Task3", "Task4", "Task4", "Task4", "Task4", "", "", "", "", "", "" };
            testlist.Add(test2);
            Test test3 = new Test();
            test3.name = "name3";
            //test3.task = new string[16] { "", "", "", "", "", "", "Task4", "Task4", "Task4", "Task4", "", "", "", "", "", "" };
            testlist.Add(test3);




            IEnumerable<Test> testreturn = testlist;


            return View(testreturn.ToList());
        }

        public ActionResult test()
        {
            List<Test> testlist = new List<Test>();

            //localhost2.TestWebserviceService TWS = new localhost2.TestWebserviceService();
            //TWS.Timeout = 20000;
            //localhost2.Test[] testresult = TWS.test();

            Test test1 = new Test();
            Test test2 = new Test();
            Test test3 = new Test();
            taskWS.TaskWebserviceService taskws = new taskWS.TaskWebserviceService();
            taskws.Timeout = 2000;
            taskWS.Task[] tasklist1 = taskws.getTask(1);
            taskWS.Task[] tasklist2 = taskws.getTask(2);
            taskWS.Task[] tasklist3 = taskws.getTask(3);
            test1.setTasklist(tasklist1, "Employee1",2);
            test2.setTasklist(tasklist2, "Employee2",3);
            test3.setTasklist(tasklist3, "Employee3",1);
            testlist.Add(test1);
            testlist.Add(test2);
            testlist.Add(test3);
            //localhost.CustomerWebserviceService CWS = new localhost.CustomerWebserviceService();
            //CWS.Timeout = 2000;
            //localhost.Customer[] aaa = CWS.findCustomerArray();

            //Test cust;
            //foreach (localhost.Customer cust2 in aaa)
            //{
            //    cust = new Test();
            //    cust.name = "aaa";
            //    test2.Add(cust);
            //}

            //Test test1 = new Test();
            //test1.name = "name1";
            //test1.task = new string[16] { "Taks1", "Taks1", "Taks1", "Taks1", "Task2", "Task2", "", "", "", "", "", "", "", "", "", "" };
            //testlist.Add(test1);
            //Test test2 = new Test();
            //test2.name = "name2";
            //test2.task = new string[16] { "Taks1", "Taks1", "Taks1", "Taks1", "Task3", "Task3", "Task4", "Task4", "Task4", "Task4", "", "", "", "", "", "" };
            //testlist.Add(test2);
            //Test test3 = new Test();
            //test3.name = "name3";
            //test3.task = new string[16] { "", "", "", "", "", "", "Task4", "Task4", "Task4", "Task4", "", "", "", "", "", "" };
            //testlist.Add(test3);




            IEnumerable<Test> testreturn = testlist;


            return View(testreturn.ToList());
        }

    }
}