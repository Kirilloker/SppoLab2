using SppoLab2.Script;
using SppoLab2.Script.Courses;
using SppoLab2.Script.Users;
using SppoLab2.Script.Workinging;
using SppoLab2.WindowsForm;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace SppoLab2.Script;

internal class CreateCourse : PrintFunctional
{
    public CreateCourse(String _mainLabel, List<GetInfo> _labels, Admin _admin) : base(_mainLabel, _labels, _admin)
    {
        CreateTextBox();
        CreateButton("Добавить работу", AddWork);
        CreateButton("Создать", SaveCourse);


    }

    List<Work> works = new List<Work>();

    public void AddWork(object sender, EventArgs e)
    {
        var newWindow = new PrintAllWorks(works, "Список всех заданий", new List<GetInfo>(admin.GetListWork()), admin);
        newWindow.Show();
    }

    public void SaveCourse(object sender, EventArgs e)
    {
        if (textBox[0].Text == "" || textBox[1].Text == "")
        {
            MessageBox.Show("Какое-то поле не заполнено!", "Warning");
            return;
        }

        if (works.Count == 0)
        {
            MessageBox.Show("Вы не выбрали ниодной работы!", "Warning");
            return;
        }

        try
        {
            int.Parse(textBox[2].Text);
        }
        catch (Exception)
        {
            MessageBox.Show("Не правильно указано количество свободных мест!", "Warning");
            return;
            throw;
        }


        Course course = new Course(
            textBox[0].Text, 
            textBox[1].Text, 
            int.Parse(textBox[2].Text)
            );

        for (int i = 0; i < works.Count; i++)
        {
            course.AddWork(works[i]);
        }

        admin.AddCourse(course);

        this.Close();
    }
}
