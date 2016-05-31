using System;
using System.Collections.Generic;

using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TMS.Models;

namespace TMS.Repositories
{
    /// <summary>
    /// Class that represents the Users table in the MySQL Database
    /// </summary>
    public class UserTable<TUser>
        where TUser : IdentityUser
    {
        private localhostUser.UserWebserviceService UWS;

        /// <summary>
        /// Constructor that takes a MySQLDatabase instance 
        /// </summary>
        /// <param name="database"></param>
        public UserTable(localhostUser.UserWebserviceService uws)
        {
            UWS = uws;
        }

        /// <summary>
        /// Returns the user's name given a user id
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public string GetUserName(string userId)
        {
            localhostUser.User uwsUser = new localhostUser.User();
            uwsUser = UWS.selectUserById(userId);
            return uwsUser.username;
        }

        /// <summary>
        /// Returns a User ID given a user name
        /// </summary>
        /// <param name="userName">The user's name</param>
        /// <returns></returns>
        public string GetUserId(string userName)
        {
            localhostUser.User uwsUser = new localhostUser.User();
            uwsUser = UWS.selectUserByName(userName);
            return uwsUser.id;
        }

        /// <summary>
        /// Returns an TUser given the user's id
        /// </summary>
        /// <param name="userId">The user's id</param>
        /// <returns></returns>
        public TUser GetUserById(string userId)
        {
            localhostUser.User uwsUser = new localhostUser.User();
            uwsUser = UWS.selectUserById(userId);
            TUser user = (TUser)Activator.CreateInstance(typeof(TUser));
            user.Id = uwsUser.id;
            user.UserName = uwsUser.username;
            user.PasswordHash = uwsUser.password;
            user.Email = uwsUser.username;
            user.SecurityStamp = uwsUser.securityStamp;
            return user;
        }

        /// <summary>
        /// Returns a list of TUser instances given a user name
        /// </summary>
        /// <param name="userName">User's name</param>
        /// <returns></returns>
        public List<TUser> GetUserByName(string userName)
        {
            List<TUser> users = new List<TUser>();
            localhostUser.User uwsUser = new localhostUser.User();
            uwsUser = UWS.selectUserByName(userName);
            if (uwsUser.username != null)
            {
                TUser user = (TUser)Activator.CreateInstance(typeof(TUser));
                user.Id = uwsUser.id;
                user.UserName = uwsUser.username;
                user.PasswordHash = uwsUser.password;
                user.SecurityStamp = uwsUser.securityStamp;
                user.Email = uwsUser.username;
                users.Add(user);
            }
            return users;
        }

        public List<TUser> GetUserByEmail(string email)
        {
            List<TUser> users = new List<TUser>();
            localhostUser.User uwsUser = new localhostUser.User();
            uwsUser = UWS.selectUserByName(email);
            if (uwsUser.username != null)
            {
                TUser user = (TUser)Activator.CreateInstance(typeof(TUser));
                user.Id = uwsUser.id;
                user.UserName = uwsUser.username;
                user.PasswordHash = uwsUser.password;
                user.SecurityStamp = uwsUser.securityStamp;
                user.Email = uwsUser.username;
                users.Add(user);
            }
            return users;
        }

        /// <summary>
        /// Return the user's password hash
        /// </summary>
        /// <param name="userId">The user's id</param>
        /// <returns></returns>
        public string GetPasswordHash(string userId)
        {
            localhostUser.User uwsUser = new localhostUser.User();
            uwsUser = UWS.selectUserById(userId);
            var passHash = uwsUser.password;
            return passHash;
        }

        /// <summary>
        /// Sets the user's password hash
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="passwordHash"></param>
        /// <returns></returns>
        public int SetPasswordHash(string userId, string passwordHash)
        {
            localhostUser.User uwsUser = new localhostUser.User();
            uwsUser = UWS.selectUserById(userId);
            uwsUser.password = passwordHash;
            UWS.updateUser(uwsUser);
            return 1;
        }

        /// <summary>
        /// Returns the user's security stamp
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public string GetSecurityStamp(string userId)
        {
            localhostUser.User uwsUser = new localhostUser.User();
            uwsUser = UWS.selectUserById(userId);
            return uwsUser.securityStamp;
        }

        /// <summary>
        /// Inserts a new user in the Users table
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public int Insert(TUser user)
        {
            localhostUser.User uwsUser = new localhostUser.User();
            uwsUser.id = user.Id;
            uwsUser.password = user.PasswordHash;
            uwsUser.username = user.UserName;
            uwsUser.securityStamp = user.SecurityStamp;
            UWS.createUser(uwsUser);
            return 1;
        }

        /// <summary>
        /// Deletes a user from the Users table
        /// </summary>
        /// <param name="userId">The user's id</param>
        /// <returns></returns>
        private int Delete(string userId)
        {
            UWS.deleteUser(userId);
            return 1;
        }

        /// <summary>
        /// Deletes a user from the Users table
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public int Delete(TUser user)
        {
            return Delete(user.Id);
        }

        /// <summary>
        /// Updates a user in the Users table
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public int Update(TUser user)
        {
            localhostUser.User uwsUser = new localhostUser.User();
            uwsUser.id = user.Id;
            uwsUser.password = user.PasswordHash;
            uwsUser.username = user.UserName;
            uwsUser.securityStamp = user.SecurityStamp;
            UWS.updateUser(uwsUser);
            return 1;
        }
    }
}

