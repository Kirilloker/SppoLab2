using SppoLab2.Script;
using SppoLab2.Script.Users;
using SppoLab2.Script.Workinging;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace SppoLab2.WindowsForm
{
    public partial class AdminUI : Form
    {
        Admin admin;

        public AdminUI()
        {
            admin = new Admin();
            InitializeComponent();
        }


        private void CreateNewStudent(object sender, EventArgs e)
        {
            List<Task> tasks = new List<Task>();
            tasks.Add(new Task("ФИО:"));
            tasks.Add(new Task("Группа:"));

            var newWindow = new SppoLab2.Script.CreateStudent(
                "Регистрация студента",
                new List<GetInfo>(tasks),
                admin);

            newWindow.Show();
        }

        public void AddNewStudent(Student student)
        {
            admin.AddStudent(student);
        }

        private void PrintAllStudent(object sender, EventArgs e)
        {
            var newWindow = new CheckAllStudentsUI("Список всех студентов", new List<GetInfo>(admin.GetListStudents()), admin);
            newWindow.Show();
        }

        private void PrintAllTask(object sender, EventArgs e)
        {
            var newWindow = new PrintAllTaskUI("Список всех заданий", new List<GetInfo>(admin.GetListTasks()), admin);
            newWindow.Show();
        }

        private void PrintAllWork(object sender, EventArgs e)
        {
            var newWindow = new PrintAllWorkUI("Список всех работ", new List<GetInfo>(admin.GetListWork()), admin);
            newWindow.Show();
        }

        private void PrintAllCourse(object sender, EventArgs e)
        {
            var newWindow = new PrintAllCourseUI("Список всех курсов", new List<GetInfo>(admin.GetListCourse()), admin);
            newWindow.Show();
        }

        private void CreateNewCourse(object sender, EventArgs e)
        {
            List<Task> tasks = new List<Task>();
            tasks.Add(new Task("Название:"));
            tasks.Add(new Task("Описание:"));
            tasks.Add(new Task("Количество свободных мест:"));

            var newWindow = new SppoLab2.Script.CreateCourse(
                "Создание нового курса",
                new List<GetInfo>(tasks),
                admin);

            newWindow.Show();
        }

        private void CreateNewWork(object sender, EventArgs e)
        {
            List<Task> tasks = new List<Task>();
            tasks.Add(new Task("Название:"));
            tasks.Add(new Task("Описание:"));

            var newWindow = new SppoLab2.Script.CreateWork(
               "Создание новой работы",
               new List<GetInfo>(tasks),
               admin);


            newWindow.Show();
        }

        private void CreateNewTask(object sender, EventArgs e)
        {
            List<Task> tasks = new List<Task>();
            tasks.Add(new Task("Текст задания:"));

            var newWindow = new CreateTaskForm("Создание нового задания", new List<GetInfo>(tasks), admin);
            newWindow.Show();
        }

        public List<Student> GetStudents()
        {
            return admin.GetListStudents();
        }

        public void DeleteStudent(int countStudent)
        {
            admin.DeleteStudent(countStudent);
        }

        public void CreateNewStudent(string FIO, string group)
        {
            admin.CreateNewStudent(FIO, group);
        }

        private void AdminUI_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public Admin GetAdmin()
        {
            return admin;
        }
    }
}
