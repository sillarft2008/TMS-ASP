using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TMS.Models
{
    public class Task
    {
        public int id { get; set; }
        public string name { get; set; }
        public int duration { get; set; }
        public int start { get; set; }

        public void setTask(localhost2.Task task)
        {
            this.id = task.id;
            this.name = task.name;
            this.duration = task.duration;
            this.start = task.start;
        }



    }


}