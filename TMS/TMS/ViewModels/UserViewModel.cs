using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TMS.ViewModels
{
    public class UserViewModel
    {
        public TMS.localhostUser.User user { get; set; }

        public List<TMS.localhostUser.Role> UserRoles { get; set; }
        
        public List<TMS.localhostUser.Role> RoleList { get; set; }
    }
}