using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TASKMANAGER
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            Program.AllTasksLoading();
            ListboxRefresh();
        }
        private void TextBoxClean()
        {
            textBoxTaskDescription.Text = String.Empty;
        }
        private void buttonAddTask_Click(object sender, EventArgs e)
        {
            
            using (StreamWriter file = new StreamWriter(@"tasks.txt", true))
            {
                file.WriteLine($"{textBoxTaskDescription.Text};{true};{1};{Program.currentUser.UserId};{Program.currentUser.UserId}");
            }
            TextBoxClean();
            Program.AllTasksLoading();
            ListboxRefresh();


        }
        private void ListboxClear()
        {
            listBoxToDo.Items.Clear();
            listBoxInProgress.Items.Clear();
            listBoxDone.Items.Clear();
        }
        private void ListboxRefresh()
        {
            ListboxClear();
            foreach (Task task in Program.AllTasks)
            {
                if (task != null && task.TaskVisible && task.TaskOwner == Program.currentUser.UserId)
                {
                    if (task.TaskStatus == 1)
                    {
                        listBoxToDo.Items.Add(task);
                    }
                    else if (task.TaskStatus == 2)
                    {
                        listBoxInProgress.Items.Add(task);
                    }
                    else if (task.TaskStatus == 3)
                    {
                        listBoxDone.Items.Add(task);
                    }

                }
            }

        }
    }
}
