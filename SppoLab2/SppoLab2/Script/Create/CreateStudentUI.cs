using SppoLab2.Script.Users;
using SppoLab2.Script.Workinging;
using SppoLab2.WindowsForm;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SppoLab2.Script;

internal class CreateStudentUI : SketchUI
{
    public CreateStudentUI()
    {
        List<Task> line = new List<Task>();
        line.Add(new Task("ФИО:"));
        line.Add(new Task("Группа:"));

        CreateWindows("Регистрация студента", new List<GetInfo>(line));

        CreateTextBox();
        CreateButton("Зарегистрировать", RegistrationStudent);
    }

    public void RegistrationStudent(object sender, EventArgs e)
    {
        if (textBox[0].Text == "" || textBox[1].Text == "")
        {
            MessageBox.Show("Какое-то поле не заполнено!", "Warning");
        }
        else
        {
            admin.AddNewStudent(textBox[0].Text, textBox[1].Text);
            this.Close();
        }
    }

}
