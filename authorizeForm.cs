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
    public partial class authorizeForm : Form
    {
        public authorizeForm()
        {
            InitializeComponent();
            // прогружаем в кучу информацию о пользователях
            Program.AllCurrentUser = new ProgramUser[50];
            using (StreamReader file = new StreamReader(@"users.txt"))
            {
                string line;
                int i = 0;
                while ((line = file.ReadLine()) != null)
                {
                    string[] linemass = line.Split(' ');
                    Program.AllCurrentUser[i] = new ProgramUser(Convert.ToInt32(linemass[0]), linemass[1], linemass[2], linemass[3], linemass[4], linemass[5]);
                    labelAuthLogin.Text = Program.AllCurrentUser[0].ToString();

                }
            }
            //
        }

        private void buttonAuthorize_Click(object sender, EventArgs e)
        {
            //TASKMANAGER.Program.currentUser = new ProgramUser();
            string log = textBoxAuthLogin.Text;
            string pas = textBoxAuthPass.Text;
            
        }
    }
}
