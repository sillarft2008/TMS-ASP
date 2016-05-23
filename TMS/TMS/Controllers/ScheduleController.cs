using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TMS.Controllers
{
    public class ScheduleController : Controller
    {
        // GET: Schedule
        public ActionResult Index()
        {
            //localhostSchedule.ScheduleWebserviceService SWS = new localhostSchedule.ScheduleWebserviceService();
            //SWS.Timeout = 2000;
            //localhostEmployee.EmployeeWebserviceService EWS = new localhostEmployee.EmployeeWebserviceService();
            //EWS.Timeout = 2000;
            //localhostSchedule.Schedule[] scheduleArray = SWS.findScheduleArray();
            //localhostEmployee.Employee[] employeeArray = EWS.getAllEmployees();
            TMS.Models.Schedule schedule = new TMS.Models.Schedule();
            //schedule.employeeArray = employeeArray;
            //schedule.scheduleArray = scheduleArray;
            return View(schedule);
        }
        public ActionResult test()
        {
            //input:
            int competencyId = 4;
            DateTime startDateTime = new DateTime(2016, 01, 01);
            DateTime inputDuration = new DateTime(1970, 01, 01, 02, 00, 00);

            //constants
            int intervalTimeMinute = 30;
            DateTime startWorkDay = new DateTime(2016, 01, 01, 08, 00, 00);
            DateTime endWorkDay = new DateTime(2016, 01, 01, 18, 00, 00);

            DateTime existingScheduleStartTime;
            DateTime existingScheduleDuration;
            DateTime d;

            List<TMS.Models.Schedule> scheduleList = new List<TMS.Models.Schedule>();

            TMS.Models.ScheduleCell cell;
            List<Models.ScheduleCell> celllist = new List<Models.ScheduleCell>();
            TMS.Models.Schedule schedule;
            schedule = new TMS.Models.Schedule();
                        
            // setup heading
            for (DateTime time = startWorkDay; time < endWorkDay; time = time.AddMinutes(intervalTimeMinute)) { 
                cell = new TMS.Models.ScheduleCell();
                cell.ScheduleName = time.ToShortTimeString();
                celllist.Add(cell);
            }
            schedule.scheduleCellList = celllist;
            scheduleList.Add(schedule);

            localhostEmployee.EmployeeWebserviceService EWS = new localhostEmployee.EmployeeWebserviceService();
            EWS.Timeout = 2000;
            localhostEmployee.Employee[] employeeArray = EWS.getAllEmployees();
            if (employeeArray != null)
            {
                foreach (localhostEmployee.Employee employee in employeeArray)
                {
                    schedule = new TMS.Models.Schedule();
                    schedule.employee = employee;
                    localhostEC.EmployeeCompetencyWebserviceService ECWS = new localhostEC.EmployeeCompetencyWebserviceService();
                    localhostEC.EmployeeCompetency[] employeeCompetencyArray = ECWS.findAllEmployeeCompetencies(employee.id);
                    schedule.color = "red";
                    if (employeeCompetencyArray != null)
                    {
                        foreach (localhostEC.EmployeeCompetency employeeCompetency in employeeCompetencyArray)
                        {
                            if (employeeCompetency.competencyId == competencyId)
                            {
                                schedule.color = "green";
                            }
                        }
                    }
                    localhostSchedule.ScheduleWebserviceService SWS = new localhostSchedule.ScheduleWebserviceService();
                    EWS.Timeout = 2000;
                    localhostSchedule.Schedule[] scheduleArray = SWS.findScheduleArrayByEmployeeDate(employee.id, startDateTime);
                    if (scheduleArray != null)
                    {
                        celllist = new List<Models.ScheduleCell>();
                        foreach (localhostSchedule.Schedule schedule2 in scheduleArray)
                        {
                            celllist = new List<Models.ScheduleCell>();

                            existingScheduleStartTime = new DateTime(2016, 01, 01, 12, 00, 00);
                            existingScheduleDuration = new DateTime(1970, 01, 01, 02, 00, 00);
                            existingScheduleDuration = (DateTime)schedule2.duration;
                            existingScheduleStartTime = (DateTime)schedule2.startTimeDate;

                            for (d = startWorkDay; d < existingScheduleStartTime.AddHours(-inputDuration.Hour).AddMinutes(-inputDuration.Minute); d = d.AddMinutes(intervalTimeMinute))
                            {
                                cell = new TMS.Models.ScheduleCell();
                                cell.Color = "green";
                                cell.Collspan = 1;
                                cell.Id = 1;
                                cell.ScheduleName = d.ToLongTimeString();
                                celllist.Add(cell);
                            }
                            for (d = d; d < existingScheduleStartTime; d = d.AddMinutes(intervalTimeMinute))
                            {
                                cell = new TMS.Models.ScheduleCell();
                                cell.Color = "yellow";
                                cell.Collspan = 1;
                                cell.Id = 1;
                                cell.ScheduleName = d.ToLongTimeString();
                                celllist.Add(cell);
                            }


                            cell = new TMS.Models.ScheduleCell();
                            cell.schedule = schedule2;
                            cell.Color = "red";
                            int ttt = (existingScheduleDuration.Hour * 60 + existingScheduleDuration.Minute) / intervalTimeMinute;
                            cell.Collspan = ttt;
                            cell.Id = schedule2.id;
                            cell.ScheduleName = ttt.ToString();
                            celllist.Add(cell);
                            schedule.scheduleCellList = celllist;

                            for (d = d.AddHours(existingScheduleDuration.Hour).AddMinutes(existingScheduleDuration.Minute); d < endWorkDay.AddHours(-inputDuration.Hour).AddMinutes(-inputDuration.Minute); d = d.AddMinutes(intervalTimeMinute))
                            {
                                cell = new TMS.Models.ScheduleCell();
                                cell.Color = "green";
                                cell.Collspan = 1;
                                cell.Id = 1;
                                cell.ScheduleName = d.ToLongTimeString();
                                celllist.Add(cell);
                            }
                            for (d = d; d < endWorkDay; d = d.AddMinutes(intervalTimeMinute))
                            {
                                cell = new TMS.Models.ScheduleCell();
                                cell.Color = "yellow";
                                cell.Collspan = 1;
                                cell.Id = 1;
                                cell.ScheduleName = d.ToLongTimeString();
                                celllist.Add(cell);
                            }

                        }
                    }
                    scheduleList.Add(schedule);
                }
            }

            return View(scheduleList);
        }
    }
}