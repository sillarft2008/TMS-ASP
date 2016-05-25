using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TMS.Models
{
    public class Schedule
    {
        public List<ScheduleCell> scheduleCellList { get; set; }
        public localhostEmployee.Employee employee { get; set; }
        public String color { get; set; }

        public localhostSchedule.Employee getScheduleEmployee() {
            localhostSchedule.Employee emp = new localhostSchedule.Employee();
            emp.id = this.employee.id;
            emp.firstName = this.employee.firstName;
            emp.lastName = this.employee.lastName;
            emp.address = this.employee.address;
            emp.birthdate = this.employee.birthdate;
            emp.email = this.employee.email;
            emp.telefone = this.employee.telefone;
            return emp;
        }
    }
}