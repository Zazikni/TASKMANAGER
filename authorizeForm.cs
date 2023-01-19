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
            Program.UsersListLoading();

        }
        

        private void buttonAuthorize_Click(object sender, EventArgs e)
        {
            
            string log = textBoxAuthLogin.Text;
            string pas = textBoxAuthPass.Text;
            bool authorizeStatus = false;
            foreach (ProgramUser user in Program.AllCurrentUser)
            {
                if (user != null && log == user.Login && pas == user.Password )
                {
                    Program.UserLogin(user);
                    authorizeStatus = true;
                    mainForm mForm = new mainForm();
                    mForm.ShowDialog();
                    this.Hide();
                    break;
                }
            }
            if (!authorizeStatus)
            {
                MessageBox.Show("Ошибка авторизации");
            }
            
        }

        public  void buttonRegistration_Click(object sender, EventArgs e)
        {
            registrationForm regForm = new registrationForm();
            regForm.Show();
            //this.Hide();
            
        }
        
    }
}
