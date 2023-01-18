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
            Program.usersListLoading();
            labelAuthLogin.Text = Program.AllCurrentUser[0].ToString();

        }
        

        private void buttonAuthorize_Click(object sender, EventArgs e)
        {
            //TASKMANAGER.Program.currentUser = new ProgramUser();
            string log = textBoxAuthLogin.Text;
            string pas = textBoxAuthPass.Text;
            bool authorizeStatus = false;
            foreach (ProgramUser user in Program.AllCurrentUser)
            {
                if (user != null && log == user.Login && pas == user.Password )
                {
                    Program.currentUser = user;
                    MessageBox.Show("Great");
                    authorizeStatus = true;
                    break;
                }
            }
            if (!authorizeStatus)
            {
                MessageBox.Show("Ошибка авторизации");
            }
            
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            registrationForm newForm = new registrationForm();
            newForm.Show();
            //this.Hide();
            
        }
        
    }
}
