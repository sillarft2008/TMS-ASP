using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TMS.Models
{
    public class ScheduleCell
    {
        public int Collspan { get; set; }
        public String Color { get; set; }
        public String ScheduleName { get; set; }
        public int Id { get; set; }
        public localhostSchedule.Schedule schedule { get; set; }
    }
}