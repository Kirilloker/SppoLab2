using SppoLab2.Script.Workinging;
using SppoLab2.WindowsForm;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SppoLab2.Script;

internal class CreateTaskUI : SketchUI
{
    public CreateTaskUI()
    {
        List<Task> line = new List<Task>();
        line.Add(new Task("Текст задания:"));

        CreateWindows("Создание задания", new List<GetInfo>(line));
        CreateTextBox();
        CreateButton("Сохранить", SaveTask);
    }

    public void SaveTask(object sender, EventArgs e)
    {
        if (textBox[0].Text == "")
        {
            MessageBox.Show("Поле Задание не заполнено!", "Warning");
            return;
        }

        admin.AddTask(new Task(textBox[0].Text));

        this.Close();
    }

}
