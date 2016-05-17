using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TMS.Models
{
    public class Employee_Competency
    {
        [Key]
        public int Id { get; set; }
        public int employeeId { get; set; }
        public int competencyId { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Competency Competency { get; set; }
    }
}