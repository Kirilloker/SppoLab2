using SppoLab2.Script;
using SppoLab2.Script.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SppoLab2.WindowsForm
{
    public partial class LogInUI : Form
    {
        AdminUI adminUI = new AdminUI();

        public LogInUI()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Student> students = adminUI.GetStudents();

            if (students == null || students.Count == 0)
            {
                MessageBox.Show("Ниодного студента не найдена!", "Warning");
                return;
            }

            var newForm = new LogInStudentUI();
            newForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminUI.Show();
        }
    }
}
