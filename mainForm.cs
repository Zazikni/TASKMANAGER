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
            labelUserInfo.Text = Program.currentUser.ToString();
        }
        private void TextBoxClear()
        {
            textBoxTaskDescription.Text = String.Empty;
        }
        private void buttonAddTask_Click(object sender, EventArgs e)
        {
            Program.SaveResult();

            using (StreamWriter file = new StreamWriter(@"tasks.txt", true))
            {
                Task buff = new Task(textBoxTaskDescription.Text, true, 1, Program.currentUser.UserId, Program.currentUser.UserId);
                file.WriteLine(buff.ToStringFormat());
            }            
            Program.AllTasksLoading();
            ListboxRefresh();
            TextBoxClear();

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

        private void listBoxToDo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxToDo.SelectedIndex != -1)
            {
                buttonReplaceToInProgress.Enabled = true;
            }
        }        
        private void listBoxDone_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxDone.SelectedIndex != -1)
            {
                buttonBackToInProgress.Enabled = true;
                buttonDoneDelete.Enabled = true;
            }
        }
        private void listBoxInProgress_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxInProgress.SelectedIndex != -1)
            {
                buttonReplaceToDone.Enabled = true;
                buttonBackToToDo.Enabled = true;
            }

        }
        private void buttonReplaceToInProgress_Click(object sender, EventArgs e)
        {
            Task buff = (Task)listBoxToDo.SelectedItem;
            Program.ChangeStatus(buff.TaskId, 2);
            ListboxRefresh();
            buttonReplaceToInProgress.Enabled = false;
        }

        private void buttonBackToToDo_Click(object sender, EventArgs e)
        {
            Task buff = (Task)listBoxInProgress.SelectedItem;
            Program.ChangeStatus(buff.TaskId, 1);
            ListboxRefresh();
            buttonBackToToDo.Enabled = false;
            buttonReplaceToDone.Enabled = false;
        }

        private void buttonReplaceToDone_Click(object sender, EventArgs e)
        {
            Task buff = (Task)listBoxInProgress.SelectedItem;
            Program.ChangeStatus(buff.TaskId, 3);
            ListboxRefresh();
            buttonReplaceToDone.Enabled = false;
            buttonBackToToDo.Enabled = false;
        }

        private void buttonBackToInProgress_Click(object sender, EventArgs e)
        {
            Task buff = (Task)listBoxDone.SelectedItem;
            Program.ChangeStatus(buff.TaskId, 2);
            ListboxRefresh();
            buttonBackToInProgress.Enabled = false;
            buttonDoneDelete.Enabled = false;
        }

        private void buttonDoneDelete_Click(object sender, EventArgs e)
        {
            Task buff = (Task)listBoxDone.SelectedItem;
            Program.ChangeVisible(buff.TaskId);
            ListboxRefresh();
            buttonBackToInProgress.Enabled = false;
            buttonDoneDelete.Enabled = false;
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.SaveResult();
            this.Owner.Show();
            //Program.currentUser = null;
            //Program.AllTasks = null;
            
        }
    }
}
