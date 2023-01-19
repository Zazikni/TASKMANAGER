/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TASKMANAGER
{
    public class MyApplicationContext : ApplicationContext
    {
        public MyApplicationContext()
        {
            Form loginForm = new registrationForm();
            registrationForm.UserCancelledLogin += OnUserCancelledLogin;
            registrationForm.UserAuthorized += OnUserIsAuthorised;
        }

        private void OnUserCancelledLogin(object sender, EventArgs e)
        {
            ExitThread();
        }

        private void OnUserAuthorised(object sender, EventArgs e)
        {
            Form loginForm = (Form)sender;
            loginForm.Close();
            Form mainForm = new MainForm();
            mainForm.FormClosed += OnformClosed();
            mainForm.Show();
        }

        private void OnFormClosed(object sender, FormClosedEventArgs e)
        {
            ExitThread();
        }
    }
}
*/