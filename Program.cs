using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TASKMANAGER
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new authorizeForm());
            //Application.Run(new registrationForm());

        }
        static public ProgramUser currentUser; // текуший пользователь программы
        static public ProgramUser [] AllCurrentUser; // список всех пользователей для авторизации и назначения


        // выгружает из файла данные пользователей 
        static public void usersListLoading()
        {
            
            Program.AllCurrentUser = new ProgramUser[50];
            using (StreamReader file = new StreamReader(@"users.txt"))
            {
                string line;
                int i = 0;
                while ((line = file.ReadLine()) != null)
                {
                    string[] linemass = line.Split(' ');
                    Program.AllCurrentUser[i] = new ProgramUser(Convert.ToInt32(linemass[0]), linemass[1], linemass[2], linemass[3], linemass[4], linemass[5]);
                    i++;
                }
            }

        }
        //добавление текущего пользователя
        static public void userLogin(ProgramUser user)
        {
            currentUser = user;
        }
        static public void userExit(ProgramUser user)
        {
            currentUser = null;
            Application.Restart();
        }




    }
}
