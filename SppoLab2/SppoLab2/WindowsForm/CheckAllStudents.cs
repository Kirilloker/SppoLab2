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
    public partial class CheckAllStudents : Form
    {
        private AdminUI admin;
        private List<Student> students = new List<Student>();
        private List<Label> FIOStudents = new List<Label>();
        private List<Button> button_check = new List<Button>();
        private List<Button> button_delete = new List<Button>();
       // private List<Button> button_edit = new List<Button>();


        public CheckAllStudents(AdminUI _admin)
        {
            InitializeComponent();
            admin = _admin;

            PrintAllStudents();

        }

        private void FIOStudent_Click(object sender, EventArgs e)
        {

        }

        private void PrintAllStudents()
        {
            students = admin.GetStudents();

            for (int i = 0; i < students.Count; i++)
            {
                // Создание Надписи ФИО
                Label FIOStudent = new Label();
                FIOStudent.Text = students[i].name;
                FIOStudent.Location = new Point(10,20 + 60*i);
                FIOStudent.Font = new Font(DefaultFont.Name, 12);
                this.Controls.Add(FIOStudent);
                FIOStudents.Add(FIOStudent);

                // Создание Кнопки Подробнее
                Button checkButton = new Button();
                checkButton.Text = "Подробнее";
                //checkButton.Location = new Point(280, 10 + 60 * i);
                checkButton.Location = new Point(400, 10 + 60 * i);
                checkButton.Font = new Font(DefaultFont.Name, 10);
                checkButton.Size = new Size(97, 40);
                checkButton.Tag = i;
                checkButton.Click += new EventHandler(checkBut);
                this.Controls.Add(checkButton);
                button_check.Add(checkButton); 


                // Создание Кнопки Редактировать
                //Button editButton = new Button();
                //editButton.Text = "Редактировать";
                //editButton.Location = new Point(383, 10 + 60 * i);
                //editButton.Font = new Font(DefaultFont.Name, 10);
                //editButton.Size = new Size(122, 40);
                //editButton.Tag = i;
                //editButton.Click += new EventHandler(editBut);
                //this.Controls.Add(editButton);
                //button_edit.Add(editButton);

                // Создание Кнопки Удалить
                Button deleteButton = new Button();
                deleteButton.Text = "Удалить";
                deleteButton.Location = new Point(510, 10 + 60 * i);
                deleteButton.Font = new Font(DefaultFont.Name, 10);
                deleteButton.Size = new Size(122, 40);
                deleteButton.Tag = i;
                deleteButton.Click += new EventHandler(deleteBut);
                this.Controls.Add(deleteButton);
                button_delete.Add(deleteButton);
            }


        }

        private void deleteBut(object sender, EventArgs e)
        {
            int countStundent = (int)((Control)sender).Tag;
            Console.WriteLine(((Control)sender).Tag);
            Console.WriteLine(button_delete.Count);
            button_delete[countStundent].Dispose();
            Console.WriteLine(button_delete.Count);
            button_check[countStundent].Dispose();
            //button_edit[countStundent].Dispose();
            FIOStudents[countStundent].Dispose();

            admin.DeleteStudent(countStundent);

            button_delete.RemoveAt(countStundent);
            button_check.RemoveAt(countStundent);
            //button_edit.RemoveAt(countStundent);
            FIOStudents.RemoveAt(countStundent);
            
        }

        private void editBut(object sender, EventArgs e)
        {
            Console.WriteLine(((Control)sender).Tag);
        }

        private void checkBut(object sender, EventArgs e)
        {
            Console.WriteLine(((Control)sender).Tag);
        }

        private void CheckAllStudents_Load(object sender, EventArgs e)
        {

        }
    }
}
