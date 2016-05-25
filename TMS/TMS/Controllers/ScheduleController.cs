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
        //public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,Email,Phone,BirthDate,HomeAddress,Competencies,")] localhostSchedule.Schedule id)
        //{
        //    return View();
        //}
        //public ActionResult Edit(int? id)
        //{
        //    return View();
        //}
        public ActionResult save(int employeeId, int jobId,int competencyId, DateTime startTimeDate, DateTime duration)
        {
            TMS.localhostSchedule.Schedule schedule = new TMS.localhostSchedule.Schedule();
            schedule.id = 0;
            TMS.localhostSchedule.Employee employee = new TMS.localhostSchedule.Employee();
            TMS.localhostSchedule.Job job = new TMS.localhostSchedule.Job();
            TMS.localhostSchedule.Competency competency = new TMS.localhostSchedule.Competency();
            TMS.localhostSchedule.Item item = new TMS.localhostSchedule.Item();
            employee.id = employeeId;
            job.id = jobId;
            competency.id = competencyId;
            item.id = 1;
            schedule.employee = employee;
            schedule.job = job;
            schedule.competency = competency;
            schedule.item = item;
            schedule.startTimeDate = startTimeDate;
            duration = duration.AddYears(1);
            schedule.duration = duration;
            TMS.localhostSchedule.ScheduleWebserviceService SWS = new localhostSchedule.ScheduleWebserviceService();
            SWS.createSchedule(schedule);
            SWS.Dispose();
            return RedirectToAction("test2");
        }

        public ActionResult test()
        {
            //input(for test):
            int inputCompetencyId = 4;
            int inputJobId = 1;
            DateTime startDateTime = new DateTime(2016, 01, 01);
            DateTime inputDuration = new DateTime(1970, 01, 01, 01, 00, 00);
            localhostSchedule.Schedule inputSchedule = new localhostSchedule.Schedule();
            inputSchedule.startTimeDate = startDateTime;
            inputSchedule.duration = inputDuration;
            localhostSchedule.Competency inputCompetency = new localhostSchedule.Competency();
            inputCompetency.id = inputCompetencyId;
            inputSchedule.competency = inputCompetency;
            localhostSchedule.Job inputJob = new localhostSchedule.Job();
            inputJob.id = inputJobId;
            inputSchedule.job = inputJob;


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
            TMS.Models.Schedule scheduleRow;
            scheduleRow = new TMS.Models.Schedule();
                        
            // setup heading
            for (DateTime time = startWorkDay; time < endWorkDay; time = time.AddMinutes(intervalTimeMinute)) { 
                cell = new TMS.Models.ScheduleCell();
                cell.ScheduleName = time.ToShortTimeString();
                celllist.Add(cell);
            }
            scheduleRow.scheduleCellList = celllist;
            scheduleList.Add(scheduleRow);

            localhostEmployee.EmployeeWebserviceService EWS = new localhostEmployee.EmployeeWebserviceService();
            EWS.Timeout = 2000;
            localhostEmployee.Employee[] employeeArray = EWS.getAllEmployees();
            EWS.Dispose();
            if (employeeArray != null)
            {
                foreach (localhostEmployee.Employee employee in employeeArray)
                {
                    scheduleRow = new TMS.Models.Schedule();
                    scheduleRow.employee = employee;
                    //scheduleRow.employee = employee;
                    localhostEC.EmployeeCompetencyWebserviceService ECWS = new localhostEC.EmployeeCompetencyWebserviceService();
                    localhostEC.EmployeeCompetency[] employeeCompetencyArray = ECWS.findAllEmployeeCompetencies(employee.id);
                    ECWS.Dispose();
                    scheduleRow.color = "red";
                    if (employeeCompetencyArray != null)
                    {
                        foreach (localhostEC.EmployeeCompetency employeeCompetency in employeeCompetencyArray)
                        {
                            if (employeeCompetency.competencyId == inputSchedule.competency.id)
                            {
                                scheduleRow.color = "green";
                            }
                        }
                    }
                    localhostSchedule.ScheduleWebserviceService SWS = new localhostSchedule.ScheduleWebserviceService();
                    EWS.Timeout = 2000;
                    localhostSchedule.Schedule[] scheduleArray = SWS.findScheduleArrayByEmployeeDate(employee.id, startDateTime);
                    SWS.Dispose();
                    celllist = new List<Models.ScheduleCell>();
                    if (scheduleArray != null)
                    {
                        celllist = new List<Models.ScheduleCell>();
                        d = startWorkDay;
                        foreach (localhostSchedule.Schedule schedule2 in scheduleArray)
                        {
                            existingScheduleDuration = (DateTime)schedule2.duration;
                            existingScheduleStartTime = (DateTime)schedule2.startTimeDate;

                            for (d = d; d <= existingScheduleStartTime.AddHours(-inputDuration.Hour).AddMinutes(-inputDuration.Minute); d = d.AddMinutes(intervalTimeMinute))
                            {
                                cell = new TMS.Models.ScheduleCell();
                                localhostSchedule.Schedule schedule = new localhostSchedule.Schedule();
                                cell.Color = "green";
                                cell.Collspan = 1;
                                cell.Id = 1;
                                //cell.schedule = inputSchedule;
                                schedule.startTimeDate = d;
                                schedule.duration = inputDuration;
                                schedule.employee = scheduleRow.getScheduleEmployee();
                                schedule.job = inputSchedule.job;
                                schedule.competency = inputSchedule.competency;
                                cell.ScheduleName = schedule.startTimeDate.ToString();
                                cell.schedule = schedule;
                                celllist.Add(cell);
                            }
                            for (d = d; d < existingScheduleStartTime; d = d.AddMinutes(intervalTimeMinute))
                            {
                                cell = new TMS.Models.ScheduleCell();
                                localhostSchedule.Schedule schedule = new localhostSchedule.Schedule();
                                cell.Color = "yellow";
                                cell.Collspan = 1;
                                cell.Id = 1;
                                //cell.schedule = inputSchedule;
                                schedule.startTimeDate = d;
                                schedule.duration = inputDuration;
                                schedule.employee = scheduleRow.getScheduleEmployee();
                                schedule.job = inputSchedule.job;
                                schedule.competency = inputSchedule.competency;
                                cell.ScheduleName = schedule.startTimeDate.ToString();
                                cell.schedule = schedule;
                                celllist.Add(cell);
                            }
                            cell = new TMS.Models.ScheduleCell();
                            cell.schedule = schedule2;
                            cell.Color = "red";
                            cell.Collspan = (existingScheduleDuration.Hour * 60 + existingScheduleDuration.Minute) / intervalTimeMinute;
                            cell.Id = schedule2.id;
                            cell.ScheduleName = schedule2.job.address;
                            celllist.Add(cell);
                            scheduleRow.scheduleCellList = celllist;
                            d = d.AddHours(existingScheduleDuration.Hour).AddMinutes(existingScheduleDuration.Minute);
                        }
                        for (d = d; d <= endWorkDay.AddHours(-inputDuration.Hour).AddMinutes(-inputDuration.Minute); d = d.AddMinutes(intervalTimeMinute))
                        {
                            cell = new TMS.Models.ScheduleCell();
                            localhostSchedule.Schedule schedule = new localhostSchedule.Schedule();
                            cell.Color = "green";
                            cell.Collspan = 1;
                            cell.Id = 1;
                            //cell.schedule = inputSchedule;
                            schedule.startTimeDate = d;
                            schedule.duration = inputDuration;
                            schedule.employee = scheduleRow.getScheduleEmployee();
                            schedule.job = inputSchedule.job;
                            schedule.competency = inputSchedule.competency;
                            cell.ScheduleName = schedule.startTimeDate.ToString();
                            cell.schedule = schedule;
                            celllist.Add(cell);
                        }
                        for (d = d; d < endWorkDay; d = d.AddMinutes(intervalTimeMinute))
                        {
                            cell = new TMS.Models.ScheduleCell();
                            localhostSchedule.Schedule schedule = new localhostSchedule.Schedule();
                            cell.Color = "yellow";
                            cell.Collspan = 1;
                            cell.Id = 1;
                            //cell.schedule = inputSchedule;
                            schedule.startTimeDate = d;
                            schedule.duration = inputDuration;
                            schedule.employee = scheduleRow.getScheduleEmployee();
                            schedule.job = inputSchedule.job;
                            schedule.competency = inputSchedule.competency;
                            cell.ScheduleName = schedule.startTimeDate.ToString();
                            cell.schedule = schedule;
                            celllist.Add(cell);
                        }
                        scheduleRow.scheduleCellList = celllist;
                    }
                    else {
                            for (d = startWorkDay ; d <= endWorkDay; d = d.AddMinutes(intervalTimeMinute))
                            {
                                cell = new TMS.Models.ScheduleCell();
                                localhostSchedule.Schedule schedule = new localhostSchedule.Schedule();
                                cell.Color = "green";
                                cell.Collspan = 1;
                                cell.Id = 1;
                                //cell.schedule = inputSchedule;
                                schedule.startTimeDate = d;
                                schedule.duration = inputDuration;
                                schedule.employee = scheduleRow.getScheduleEmployee();
                                schedule.job = inputSchedule.job;
                                schedule.competency = inputSchedule.competency;
                                cell.ScheduleName = schedule.startTimeDate.ToString();
                                cell.schedule = schedule;
                                celllist.Add(cell);
                            }
                        scheduleRow.scheduleCellList = celllist;
                    }
                    scheduleList.Add(scheduleRow);

                }
            }

            return View(scheduleList);
        }

        public ActionResult test2()
        {
            //input(for test):
            //int inputCompetencyId = 4;
            //int inputJobId = 1;
            DateTime startDateTime = new DateTime(2016, 01, 01);
            //DateTime inputDuration = new DateTime(1970, 01, 01, 01, 00, 00);
            localhostSchedule.Schedule inputSchedule = new localhostSchedule.Schedule();
            inputSchedule.startTimeDate = startDateTime;
            //inputSchedule.duration = inputDuration;
            localhostSchedule.Competency inputCompetency = new localhostSchedule.Competency();
            //inputCompetency.id = inputCompetencyId;
            inputSchedule.competency = inputCompetency;
            localhostSchedule.Job inputJob = new localhostSchedule.Job();
            //inputJob.id = inputJobId;
            inputSchedule.job = inputJob;


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
            TMS.Models.Schedule scheduleRow;
            scheduleRow = new TMS.Models.Schedule();

            // setup heading
            for (DateTime time = startWorkDay; time < endWorkDay; time = time.AddMinutes(intervalTimeMinute))
            {
                cell = new TMS.Models.ScheduleCell();
                cell.ScheduleName = time.ToShortTimeString();
                celllist.Add(cell);
            }
            scheduleRow.scheduleCellList = celllist;
            scheduleList.Add(scheduleRow);

            localhostEmployee.EmployeeWebserviceService EWS = new localhostEmployee.EmployeeWebserviceService();
            EWS.Timeout = 2000;
            localhostEmployee.Employee[] employeeArray = EWS.getAllEmployees();
            EWS.Dispose();
            if (employeeArray != null)
            {
                foreach (localhostEmployee.Employee employee in employeeArray)
                {
                    scheduleRow = new TMS.Models.Schedule();
                    scheduleRow.employee = employee;
                    //scheduleRow.employee = employee;
                    localhostEC.EmployeeCompetencyWebserviceService ECWS = new localhostEC.EmployeeCompetencyWebserviceService();
                    localhostEC.EmployeeCompetency[] employeeCompetencyArray = ECWS.findAllEmployeeCompetencies(employee.id);
                    ECWS.Dispose();
                    scheduleRow.color = "red";
                    if (employeeCompetencyArray != null)
                    {
                        foreach (localhostEC.EmployeeCompetency employeeCompetency in employeeCompetencyArray)
                        {
                            if (employeeCompetency.competencyId == inputSchedule.competency.id)
                            {
                                scheduleRow.color = "green";
                            }
                        }
                    }
                    localhostSchedule.ScheduleWebserviceService SWS = new localhostSchedule.ScheduleWebserviceService();
                    EWS.Timeout = 2000;
                    localhostSchedule.Schedule[] scheduleArray = SWS.findScheduleArrayByEmployeeDate(employee.id, startDateTime);
                    SWS.Dispose();
                    celllist = new List<Models.ScheduleCell>();
                    if (scheduleArray != null)
                    {
                        celllist = new List<Models.ScheduleCell>();
                        d = startWorkDay;
                        foreach (localhostSchedule.Schedule schedule2 in scheduleArray)
                        {
                            existingScheduleDuration = (DateTime)schedule2.duration;
                            existingScheduleStartTime = (DateTime)schedule2.startTimeDate;

                            for (d = d; d < existingScheduleStartTime; d = d.AddMinutes(intervalTimeMinute))
                            {
                                cell = new TMS.Models.ScheduleCell();
                                localhostSchedule.Schedule schedule = new localhostSchedule.Schedule();
                                cell.Color = "yellow";
                                cell.Collspan = 1;
                                cell.Id = 1;
                                //cell.schedule = inputSchedule;
                                schedule.startTimeDate = d;
                                //schedule.duration = inputDuration;
                                schedule.employee = scheduleRow.getScheduleEmployee();
                                schedule.job = inputSchedule.job;
                                schedule.competency = inputSchedule.competency;
                                cell.ScheduleName = schedule.startTimeDate.ToString();
                                cell.schedule = schedule;
                                celllist.Add(cell);
                            }
                            cell = new TMS.Models.ScheduleCell();
                            cell.schedule = schedule2;
                            cell.Color = "red";
                            cell.Collspan = (existingScheduleDuration.Hour * 60 + existingScheduleDuration.Minute) / intervalTimeMinute;
                            cell.Id = schedule2.id;
                            cell.ScheduleName = schedule2.job.address;
                            celllist.Add(cell);
                            scheduleRow.scheduleCellList = celllist;
                            d = d.AddHours(existingScheduleDuration.Hour).AddMinutes(existingScheduleDuration.Minute);
                        }
                        for (d = d; d < endWorkDay; d = d.AddMinutes(intervalTimeMinute))
                        {
                            cell = new TMS.Models.ScheduleCell();
                            localhostSchedule.Schedule schedule = new localhostSchedule.Schedule();
                            cell.Color = "yellow";
                            cell.Collspan = 1;
                            cell.Id = 1;
                            //cell.schedule = inputSchedule;
                            schedule.startTimeDate = d;
                            //schedule.duration = inputDuration;
                            schedule.employee = scheduleRow.getScheduleEmployee();
                            schedule.job = inputSchedule.job;
                            schedule.competency = inputSchedule.competency;
                            cell.ScheduleName = schedule.startTimeDate.ToString();
                            cell.schedule = schedule;
                            celllist.Add(cell);
                        }
                        scheduleRow.scheduleCellList = celllist;
                    }
                    else {
                        for (DateTime time = startWorkDay; time < endWorkDay; time = time.AddMinutes(intervalTimeMinute))
                        {
                            cell = new TMS.Models.ScheduleCell();
                            cell.Id = 1;
                            cell.ScheduleName = time.ToShortTimeString();
                            celllist.Add(cell);
                        }
                        scheduleRow.scheduleCellList = celllist;
                    }
                    scheduleList.Add(scheduleRow);

                }
            }
            return View(scheduleList);
        }

    }
}