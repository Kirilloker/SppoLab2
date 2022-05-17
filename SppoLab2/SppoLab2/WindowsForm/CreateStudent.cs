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
    public partial class CreateStudent : Form
    {
        private AdminUI admin;
        public CreateStudent(AdminUI _admin)
        {
            admin = _admin ?? throw new ArgumentNullException(nameof(_admin));
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegistraionStudent_Click(object sender, EventArgs e)
        {
            if (TextFIOStudent.Text == "") 
            {
                MessageBox.Show("Поле ФИО студента не заполнено!", "Warning");
            }
            else if (TextGroupStudent.Text == "")
            {
                MessageBox.Show("Поле Группа студента не заполнено!", "Warning");
            }
            else
            {
                admin.CreateNewStudent(TextFIOStudent.Text, TextGroupStudent.Text);   
                this.Close();
            }
        }
    }
}
