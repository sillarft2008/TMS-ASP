using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TMS.ViewModels
{
    public class ScheduleViewModel
    {
        List<TMS.Models.Schedule> scheduleList { get; set; }
        List<String> headingCells { get; set; }
    }
}