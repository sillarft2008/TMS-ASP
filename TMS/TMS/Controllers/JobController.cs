using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TMS.Models;

namespace TMS.Controllers
{
    public class JobController : Controller
    {
        public ActionResult Index()
        {
            //return View(db.Customers.ToList());
            jobWS.JobWebserviceService JWS = new jobWS.JobWebserviceService();
            JWS.Timeout = 2000;
            jobWS.Job[] customerArray = JWS.findJobArray();

            return View(customerArray.ToList());
        }
        public ActionResult List(int? id)
        {
            //return View(db.Customers.ToList());
            //List<jobWS.Job> test2 = new List<jobWS.Job>();

            localhost.CustomerWebserviceService CWS = new localhost.CustomerWebserviceService();
            CWS.Timeout = 2000;
            localhost.Customer customer = CWS.findCustomer((int)id);
            jobWS.JobWebserviceService JWS = new jobWS.JobWebserviceService();
            JWS.Timeout = 2000;
            jobWS.Job[] jobArray = JWS.findCustomerJobArray((int)id);
            //jobWS.Job a = jobArray[0];
            //jobWS.Competency[] b = a.competencyArray;
            Job job = new Job();
            job.customer = customer;
            if (jobArray != null)
            {
                job.jobList = jobArray.ToList();
            }
            //jobWS.Job test = new jobWS.Job();
            
            return View(job);

        }
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            jobWS.Job job = new jobWS.Job();
            jobWS.JobWebserviceService JWS = new jobWS.JobWebserviceService();
            JWS.Timeout = 2000;
            job = JWS.findJob((int)id);
            if (job == null)
            {
                return HttpNotFound();
            }
            return View(job);
        }

        public ActionResult Create(int? customerId)
        {


            jobWS.Job job = new jobWS.Job();
            jobWS.Customer customer = new jobWS.Customer();
            customer.id = (int)customerId;
            job.customer = customer;
            return View(job);
        }

        // POST: Customers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(jobWS.Job job)
        {
            if (ModelState.IsValid)
            {
                jobWS.JobWebserviceService JWS = new jobWS.JobWebserviceService();
                JWS.Timeout = 2000;
                JWS.createJob(job);
                return RedirectToAction("List", new { id = job.customer.id });
            }

            return View(job);
        }

        // GET: Customers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            jobWS.JobWebserviceService JWS = new jobWS.JobWebserviceService();
            JWS.Timeout = 2000;
            jobWS.Job job = JWS.findJob((int)id);
            if (job == null)
            {
                return HttpNotFound();
            }
            return View(job);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,customer,Address,StartDate,EndDate")] jobWS.Job job)
        {
            if (ModelState.IsValid)
            {
                jobWS.JobWebserviceService JWS = new jobWS.JobWebserviceService();
                JWS.Timeout = 2000;
                JWS.updateJob(job);
                return RedirectToAction("List", new { id = job.customer.id });
            }
            return View(job);
        }

        // GET: Customers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            jobWS.JobWebserviceService JWS = new jobWS.JobWebserviceService();
            JWS.Timeout = 2000;
            jobWS.Job job = JWS.findJob((int)id);
            if (job == null)
            {
                return HttpNotFound();
            }
            return View(job);
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            jobWS.JobWebserviceService JWS = new jobWS.JobWebserviceService();
            JWS.Timeout = 2000;
            jobWS.Job deleteJob = JWS.findJob((int)id);
            JWS.deleteJob(deleteJob);
            return RedirectToAction("List", new { id = deleteJob.customer.id });
        }



    }

}