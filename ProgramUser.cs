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

        private int userId;
        public string userFirstName;
        public string userSecondName;
        public string userSurname;
        private string login;
        private string password;

        public ProgramUser(string UserFirstName, string UserSecondName, string UserSurname, string Login, string Password)
        {
            userFirstName = UserFirstName;
            userSecondName = UserSecondName;
            userSurname = UserSurname;
            login = Login;
            password = Password;
            using (StreamReader file = new StreamReader(@"nextId.txt"))
            {
                userId = Convert.ToInt32(file.ReadLine());
            }
            using (StreamWriter file = new StreamWriter(@"nextId.txt", false))
            {
                file.Write(++userId);
            }


        }
        public string Login
        {
            get { return login; }
            set { login = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public override string ToString()
        {
            return $"{userId} {userFirstName} {userSecondName} {userSurname}";
        }


    }
}
