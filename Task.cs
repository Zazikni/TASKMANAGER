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
        private bool taskVisible;
        private int taskStatus;
        private int taskOwner;
        private int taskCreator;
        private static int taskCounter;

        public Task(int TaskId, string TaskDescription, bool TaskVisible, int TaskStatus, int TaskOwner, int TaskCreator)
        {
            taskId = TaskId;
            taskDescription = TaskDescription;
            taskVisible = TaskVisible;
            taskStatus = TaskStatus;
            taskOwner = TaskOwner;
            taskCreator = TaskCreator;
        }
        public Task(string TaskDescription, bool TaskVisible, int TaskStatus, int TaskOwner, int TaskCreator)
        {
            taskDescription = TaskDescription;
            taskVisible = TaskVisible;
            taskStatus = TaskStatus;
            taskOwner = TaskOwner;
            taskCreator = TaskCreator;
            using (StreamReader file = new StreamReader(@"nextTaskId.txt"))
            {
                taskId = Convert.ToInt32(file.ReadLine());
                taskCounter = taskId+1;
            }
            using (StreamWriter file = new StreamWriter(@"nextTaskId.txt", false))
            {
                file.Write(++taskId);
            }
            
        }
        public bool TaskVisible
        {
            get { return taskVisible; }
            set { taskVisible = value; }
        }   
        public static  int TaskCounter
        {
            get { return taskCounter; }
        }
        public int TaskStatus
        {
            get { return taskStatus; }
            set { taskStatus = value; }
        }
        public int TaskId
        {
            get { return taskId; }
        }
        public int TaskOwner
        {
            get { return taskOwner; }
        }
        public int TaskCreator  
        {
            get { return taskCreator; }
        }
        public override string ToString()
        {
            return $"{taskDescription}";
        }
        public  string ToStringFormat()
        {
            return $"{taskId};{taskDescription};{taskVisible};{taskStatus};{taskOwner};{taskCreator}";
        }
    }
}
