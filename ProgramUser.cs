using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace TASKMANAGER
{
    internal class ProgramUser
    {

        private int UserId;
        public string UserFirstName;
        public string UserSecondName;
        public string UserSurname;
        private string Login { get; set; }
        private string Password { get; set; }
       
        public ProgramUser(string userFirstName, string userSecondName, string userSurname, string login, string password)
        {
            UserFirstName = userFirstName;
            UserSecondName = userSecondName;
            UserSurname = userSurname;
            Login = login;
            Password = password;
            using (StreamReader file = new StreamReader(@"nextId"))
            {
                UserId = Convert.ToInt32(file.ReadLine());
            }
            using (StreamWriter file = new StreamWriter(@"nextId", false))
            {
                file.Write(UserId++);
            }


        }
    }
}
