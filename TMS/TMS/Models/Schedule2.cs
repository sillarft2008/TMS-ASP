using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TMS.Models
{
    public class Schedule2
    {
        public int Id { get; set; }
        public TMS.localhostSchedule.Employee employee { get; set; }
        public TMS.localhostSchedule.Job job { get; set; }
        public TMS.localhostSchedule.Competency competency { get; set; }
        public TMS.localhostSchedule.Item item { get; set; }
        public DateTime startDateTime { get; set; }
        public DateTime duration { get; set; }

        public void setEmployee(TMS.localhostEmployee.Employee employee2) {
            this.employee.id = employee2.id;
        }
    }
}