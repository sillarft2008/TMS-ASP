using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TMS.Models
{
    public class Schedule
    {
        //public localhostEmployee.Employee[] employeeArray { get; set; }
        //public localhostSchedule.Schedule[] scheduleArray { get; set; }
        public List<ScheduleCell> scheduleCellList { get; set; }
        public localhostEmployee.Employee employee { get; set; }
        public String color { get; set; }
    }
}