using SppoLab2.Script;
using SppoLab2.Script.Users;
using SppoLab2.Script.Workinging;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SppoLab2.WindowsForm
{
    public partial class AdminUI : Form
    {
        Admin admin = Admin.getInstance();

        public AdminUI()
        {
            InitializeComponent();
        }

        private void CreateStudent(object sender, EventArgs e)
        {
            var newForm = new CreateStudentUI();
            newForm.Show();
        }

        private void PrintAllStudent(object sender, EventArgs e)
        {
            var newWindow = new PrintAllStudentsUI();
            newWindow.Show();
        }

        private void PrintAllTask(object sender, EventArgs e)
        {
            var newWindow = new PrintAllTaskUI();
            newWindow.Show();
        }

        private void PrintAllWork(object sender, EventArgs e)
        {
            var newWindow = new PrintAllWorkUI();
            newWindow.Show();
        }

        private void PrintAllCourse(object sender, EventArgs e)
        {
            var newWindow = new PrintAllCourseUI();
            newWindow.Show();
        }

        private void CreateNewCourse(object sender, EventArgs e)
        {
            var newWindow = new CreateCourseUI();
            newWindow.Show();
        }

        private void CreateWork(object sender, EventArgs e)
        {
            var newWindow = new CreateWorkUI();
            newWindow.Show();
        }

        private void CreateTask(object sender, EventArgs e)
        {
            var newWindow = new CreateTaskUI();
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

        private void SaveButton_Click(object sender, EventArgs e)
        {
            admin.Save();
        }
        private void LoadButton_Click(object sender, EventArgs e)
        {
            admin.Load();
        }
        
    }
}
