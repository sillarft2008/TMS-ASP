using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TMS.Models;

namespace TMS.Controllers
{
    public class HomeController : Controller
    {

        //ApplicationDbContext context = new ApplicationDbContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Time Management System.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "5th semester group manager.";

            return View();
        }

        [HttpGet]
        public ViewResult CustomerForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult CustomerForm(Customer customer)
        {
            if (ModelState.IsValid)
            {
                return View(customer);
            }
            else
            {
                //there is a validation error
                return View();
            }

        }
    }
}