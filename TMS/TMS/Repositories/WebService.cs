using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TMS.Repositories
{
    public class WebService : IDisposable
    {

        public localhostUser.UserWebserviceService _connection;

        public WebService()
        {
            _connection = new localhostUser.UserWebserviceService();
        }




        public void Dispose()
        {
            if (_connection != null)
            {
                _connection.Dispose();
                _connection = null;
            }
        }
    }
}