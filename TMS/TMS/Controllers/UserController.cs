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
    public class UserController : Controller
    {

       // [Authorize]
        public ActionResult Index()
        {
            List<ViewModels.UserViewModel> userList = new List<ViewModels.UserViewModel>();

            localhostUser.UserWebserviceService UWS = new localhostUser.UserWebserviceService();
            localhostUser.User[] userArray = UWS.findUserArray();

            if (userArray == null)
            {
                return View();
            }

            ViewModels.UserViewModel userview;
            foreach (localhostUser.User user in userArray)
            {
                userview = new ViewModels.UserViewModel();
                userview.user = user;
                localhostUser.Role[] roleArray = UWS.findRoleByUserId(user.id);
                List<TMS.localhostUser.Role> userrolelist = new List<TMS.localhostUser.Role>();
                if (roleArray != null)
                {
                    userrolelist = roleArray.ToList();
                    userview.UserRoles = userrolelist;
                }
                userList.Add(userview);
            }

            return View(userList);
        }


        public ActionResult Edit(String id)
        {
            ViewModels.UserViewModel UVM = new ViewModels.UserViewModel();
            localhostUser.UserWebserviceService UWS = new localhostUser.UserWebserviceService();
            localhostUser.User user = UWS.selectUserById(id);
            UVM.user = user;
            localhostUser.Role[] roleArray = UWS.findRoleByUserId(user.id);
            List<TMS.localhostUser.Role> userrolelist = new List<TMS.localhostUser.Role>();
            if (roleArray != null)
            {
                userrolelist = roleArray.ToList();
                UVM.UserRoles = userrolelist;
            }

            List<TMS.localhostUser.Role> RoleList = new List<TMS.localhostUser.Role>();
            TMS.localhostUser.Role role = new TMS.localhostUser.Role();
            localhostUser.Role[] fullroleArray = UWS.getAllRoles();
            RoleList = fullroleArray.ToList();
            UVM.RoleList = RoleList;
            return View(UVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(TMS.ViewModels.UserViewModel user, TMS.ViewModels.UserViewModel data, IEnumerable<String> roleIds)
        {
            ViewModels.UserViewModel UVM = new ViewModels.UserViewModel();
            localhostUser.UserWebserviceService UWS = new localhostUser.UserWebserviceService();
            UWS.deleteUserRoles(data.user.id);
            localhostUser.UserRole userRole;
            foreach (String roleId in roleIds)
            {
                userRole = new localhostUser.UserRole();
                userRole.roleId = roleId;
                userRole.userId = data.user.id;
                UWS.createUserRole(userRole);
            }

            //return RedirectToAction("Detail", new { jobId = data.schedule.job.id, startTimeDate = data.schedule.startTimeDate, duration = data.schedule.duration, competencyId = compIds.First() });
            return RedirectToAction("Index");
        }

        // GET: Customers/Delete/5
        public ActionResult Delete(String id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            localhostUser.User user = new localhostUser.User();
            localhostUser.UserWebserviceService UWS = new localhostUser.UserWebserviceService();
            user = UWS.selectUserById(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(String id)
        {
            localhostUser.UserWebserviceService UWS = new localhostUser.UserWebserviceService();
            UWS.deleteUser(id);
            return RedirectToAction("Index");
        }

    }
}
