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

        }
        static public ProgramUser currentUser; // текуший пользователь программы
        static public ProgramUser [] AllCurrentUser; // список всех пользователей для авторизации и назначения
        static public Task[] AllTasks; // список всех задач
        static int UsersCounter = 10; // количество пользователей
        static int TasksCounter = UsersCounter * 100; // количество задач ( общее для всех пользователей)

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
                    Program.AllTasks[i] = new Task(Convert.ToInt32(linemass[0])/*Id задачи*/, linemass[1]/*Описание*/, Convert.ToBoolean(linemass[2])/*Видимость*/, Convert.ToInt32(linemass[3])/*Статус*/, Convert.ToInt32(linemass[4])/*Исполнитель*/, Convert.ToInt32(linemass[5])/*Создатель*/);
                    i++;
                }
            }

        }
        // метод изменения статуса задачи
        static public void ChangeStatus(int taskId, int status)
        {
            foreach (Task task in Program.AllTasks)
            {
                if (task.TaskId == taskId)
                {
                    task.TaskStatus = status;
                    break;
                }
            }
        }
        // метод удаления задачи из видимого списка задач
        static public void ChangeVisible(int taskId)
        {
            foreach (Task task in Program.AllTasks)
            {
                if (task.TaskId == taskId)
                {
                    task.TaskVisible = false;
                    break;
                }
            }
        }

        //добавление текущего пользователя
        static public void UserLogin(ProgramUser user)
        {
            currentUser = user;
        }
        // метод для смены пользователя
        static public void UserExit(ProgramUser user)
        {
            currentUser = null;
            Application.Restart();
        }
        //создание массива строк задач для записи в файл
        static private string[] TaskStringMassive()
        {
            int i = 0;
            string[] result = new string[TasksCounter];
            foreach (Task task in AllTasks)
            {
                if (task != null)
                {
                    result[i] = task.ToStringFormat();
                    i++;
                }
                else
                {
                    break;
                }
            }
            return result;
        }
        // сохранение результатов работы программы
        static public void SaveResult()
        {
            File.WriteAllLines(@"tasks.txt", TaskStringMassive());

        }

    }
}
