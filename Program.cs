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
        static public Task[] AllTasks; // список всех задач
        static int UsersCounter = 10;
        static int TasksCounter = UsersCounter * 100;

        // выгружает из файла данные пользователей 
        static public void UsersListLoading()
        {
            
            Program.AllCurrentUser = new ProgramUser[UsersCounter];
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
        // выгружает из файла данные о задачах
        static public void AllTasksLoading()
        {

            Program.AllTasks = new Task[TasksCounter];
            using (StreamReader file = new StreamReader(@"tasks.txt"))
            {
                string line;
                int i = 0;
                while ((line = file.ReadLine()) != null)
                {
                    string[] linemass = line.Split(';');
                    Program.AllTasks[i] = new Task(linemass[0]/*Описание*/, Convert.ToBoolean(linemass[1])/*Видимость*/, Convert.ToInt32(linemass[2])/*Статус*/, Convert.ToInt32(linemass[3])/*Исполнитель*/, Convert.ToInt32(linemass[4])/*Создатель*/);
                    i++;
                }
            }

        }

        //добавление текущего пользователя
        static public void UserLogin(ProgramUser user)
        {
            currentUser = user;
        }
        static public void UserExit(ProgramUser user)
        {
            currentUser = null;
            Application.Restart();
        }

    }
}
