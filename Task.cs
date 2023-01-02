using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASKMANAGER
{
    internal class Task
    {
        private int taskId;
        private string taskDescription;
        private string taskStatus;
        private string taskOwner;
        private string taskCreator;
        public Task (string TaskDescription, string TaskStatus , string TaskOwner, string TaskCreator)
        {
            taskDescription = TaskDescription;
            taskStatus = TaskStatus;
            taskOwner = TaskOwner;
            taskCreator = TaskCreator;
            using (StreamReader file = new StreamReader(@"nextTaskIdId.txt"))
            {
                taskId = Convert.ToInt32(file.ReadLine());
            }
            using (StreamWriter file = new StreamWriter(@"nextTaskIdId.txt", false))
            {
                file.Write(++taskId);
            }
        }
        public string TaskStatus
        {
            get { return taskStatus; }
            set { taskStatus = value; }
        }
        public override string ToString()
        {
            return $"{taskDescription}";
        }
    }
}
