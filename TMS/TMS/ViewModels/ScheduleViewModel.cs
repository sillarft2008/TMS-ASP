using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TMS.ViewModels
{
    public class ScheduleViewModel
    {
        public TMS.localhostSchedule.Schedule schedule { get; set; }
       
        public List<TMS.localhostCompetency.Competency> Competencies { get; set; }
    }
}