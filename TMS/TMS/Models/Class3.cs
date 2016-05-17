using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TMS.Models
{
    public class Job
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Customer customer { get; set; }

        public void setJob(jobWS.Job job) {
            this.Id = job.id;
            this.Address = job.address;
            this.StartDate = (DateTime)job.startDate;
            this.EndDate = (DateTime)job.endDate;
        }

        public jobWS.Job getJob() {
            jobWS.Job job = new jobWS.Job();
            job.id = this.Id;
            job.address = this.Address;
            job.startDate = this.StartDate;
            job.endDate = this.EndDate;
            return job;
        }

    }
}