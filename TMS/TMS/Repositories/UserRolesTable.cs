using System.Collections.Generic;
using TMS.Models;

namespace TMS.Repositories
{
    /// <summary>
    /// Class that represents the UserRoles table in the MySQL Database
    /// </summary>
    public class UserRolesTable
    {
        private localhostUser.UserWebserviceService UWS;

        /// <summary>
        /// Constructor that takes a MySQLDatabase instance 
        /// </summary>
        /// <param name="database"></param>
        public UserRolesTable(localhostUser.UserWebserviceService uws)
        {
            UWS = uws;
        }

        /// <summary>
        /// Returns a list of user's roles
        /// </summary>
        /// <param name="userId">The user's id</param>
        /// <returns></returns>
        public List<string> FindByUserId(string userId)
        {
            localhostUser.Role[] roleArray = UWS.findRoleByUserId(userId);
            List<string> roles = new List<string>();
            foreach (localhostUser.Role row in roleArray)
            {
                roles.Add(row.role_name);
            }
            return roles;
        }

        /// <summary>
        /// Deletes all roles from a user in the UserRoles table
        /// </summary>
        /// <param name="userId">The user's id</param>
        /// <returns></returns>
        public int Delete(string userId)
        {
            return 0;
        }

        /// <summary>
        /// Inserts a new role for a user in the UserRoles table
        /// </summary>
        /// <param name="user">The User</param>
        /// <param name="roleId">The Role's id</param>
        /// <returns></returns>
        public int Insert(IdentityUser user, string roleId)
        {
            return 0;
        }
    }
}
