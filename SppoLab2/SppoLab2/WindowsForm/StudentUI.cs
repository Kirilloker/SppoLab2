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

            StudentFIOText.Text = student.Name;
            StudentGroupText.Text = student.Group;
        }

        private void StudentUI_Load(object sender, EventArgs e)
        {

        }


        private void StudentLabel_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var newWindow = new PrintCourseStudentUI(student);
            newWindow.Show();
        }

        private void StudentFIOText_Click(object sender, EventArgs e)
        {

        }

        private void SubscribeCourse_Click(object sender, EventArgs e)
        {
            new Thread(new ThreadStart(delegate
            {
                Application.Run(new SubscribeCourse(student));
            })).Start();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
