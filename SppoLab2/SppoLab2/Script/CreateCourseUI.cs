using SppoLab2.Script;
using SppoLab2.Script.Courses;
using SppoLab2.Script.Users;
using SppoLab2.Script.Workinging;
using SppoLab2.WindowsForm;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace SppoLab2.Script;

internal class CreateCourseUI : SketchForm
{
    public CreateCourseUI()
    {
        List<Task> line = new List<Task>();
        line.Add(new Task("Название:"));
        line.Add(new Task("Описание:"));
        line.Add(new Task("Количество свободных мест:"));

        CreateWindows("Создание курса", new List<GetInfo>(line));

        CreateTextBox();
        CreateButton("Добавить работу", AddWork);
        CreateButton("Создать", SaveCourse);
    }

    List<Work> works = new List<Work>();

    public void AddWork(object sender, EventArgs e)
    {
        var newWindow = new AddAllWorksUI(works);
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
