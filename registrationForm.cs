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
    public partial class registrationForm : Form
    {
        public registrationForm()
        {
            InitializeComponent();
        }
        private void TextBoxClean()
        {
            textBoxRegFName.Text = String.Empty;
            textBoxRegSName.Text = String.Empty;
            textBoxRegSurname.Text = String.Empty;
            textBoxRegLogin.Text = String.Empty;
            textBoxRegPass.Text = String.Empty;
        }
        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            ProgramUser newUser = new ProgramUser(textBoxRegFName.Text, textBoxRegSName.Text, textBoxRegSurname.Text, textBoxRegLogin.Text, textBoxRegPass.Text);
            using (StreamWriter file = new StreamWriter(@"users.txt", true))
            {
                file.WriteLine(newUser.ToString());
            }
            TextBoxClean();
        }
    }
}
