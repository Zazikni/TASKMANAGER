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
        private string userFirstName;
        private string userSecondName;
        private string userSurname;
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
        public ProgramUser(int UserId , string UserFirstName, string UserSecondName, string UserSurname, string Login, string Password)
        {
            userFirstName = UserFirstName;
            userSecondName = UserSecondName;
            userSurname = UserSurname;
            login = Login;
            password = Password;
            userId = UserId;


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
        public int UserId 
        { 
            get { return userId; }
        }
        public string UserFirstName
        {
            get { return userFirstName; }
        }
        public string UserSecondName
        {
            get { return userSecondName; }
        }
        public string UserSurname
        {
            get { return userSurname; }
        }
        public override string ToString()
        {
            return $"{userId} {userFirstName} {userSecondName} {userSurname} {login} {password}";
        }


    }
}
