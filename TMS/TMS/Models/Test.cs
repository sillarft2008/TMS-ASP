using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TMS.Models
{
    public class Test
    {
        public String name { get; set; }
        public Task2[] tasklist { get; set; }

        public void setTasklist(taskWS.Task[] tasklist2,String name, int count)
        {
            this.name = name;
            this.tasklist = new Task2[16];

            for (int i = 0; i < (16); i++)
            {
                Task2 addtask = new Task2();
                addtask.name = "free";
                tasklist[i] = addtask;
                tasklist[i].link  = "../Customers/Details";
            }

            foreach (taskWS.Task task in tasklist2)
            {
                for (int j = task.start; j < (task.start + task.duration); j++) {
                    tasklist[j].setTask(task);
                    tasklist[j].color = tasklist[j].name;
                    tasklist[j].link = "../Customers/Index";
                }
            }
        }

    }
}