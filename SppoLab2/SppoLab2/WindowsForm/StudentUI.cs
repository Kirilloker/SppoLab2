using SppoLab2.Script;
using SppoLab2.Script.Users;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace SppoLab2.WindowsForm
{
    public partial class StudentUI : Form
    {
        Student student;
        Admin admin;

        public StudentUI(Student _student, Admin _admin)
        {
            InitializeComponent();

            student = _student;
            admin = _admin;

            StudentFIOText.Text = student.name;
            StudentGroupText.Text = student.group;
        }

        private void StudentUI_Load(object sender, EventArgs e)
        {

        }


        private void StudentLabel_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var newWindow = new PrintCourseStudent("Список всех курсов", new List<GetInfo>(student.GetListCourse()), student);
            newWindow.Show();
        }

        private void StudentFIOText_Click(object sender, EventArgs e)
        {

        }

        private void SubscribeCourse_Click(object sender, EventArgs e)
        {
            new Thread(new ThreadStart(delegate
            {
                Application.Run(new SubscribeCourse("Запись на курс", 
                    new List<GetInfo>(admin.GetListCourse()), 
                    admin, student));
            })).Start();



        }
    }
}
