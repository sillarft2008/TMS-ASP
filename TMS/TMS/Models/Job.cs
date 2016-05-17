using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TMS.Models
{
    public class Job
    {
        public localhost.Customer customer { get; set; }
        public IEnumerable<TMS.jobWS.Job> jobList { get; set; }


    }
}