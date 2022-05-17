using SppoLab2.Script;
using SppoLab2.Script.Users;
using SppoLab2.Script.Workinging;
using SppoLab2.WindowsForm;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;


namespace SppoLab2.Script;

internal class CreateWork : PrintFunctional
{
    public CreateWork(String _mainLabel, List<GetInfo> _labels, Admin _admin) : base(_mainLabel, _labels, _admin)
    {
        CreateTextBox();
        CreateButton("Добавить задания", AddTask);
        CreateButton("Создать", SaveWork);

        CreatedCheckList();
    }

    List<Task> tasks = new List<Task>();
    CheckedListBox checkWork = new CheckedListBox();

    public void AddTask(object sender, EventArgs e)
    {
        var newWindow = new PrintAllTask(tasks, "Список всех заданий", new List<GetInfo>(admin.GetListTasks()), admin);
        newWindow.Show();
    }

    public void SaveWork(object sender, EventArgs e)
    {
        if (textBox[0].Text == "" || textBox[1].Text == "")
        {
            MessageBox.Show("Какое-то поле не заполнено!", "Warning");
            return;
        }

        if (tasks.Count == 0)
        {
            MessageBox.Show("Вы не выбрали ниодного задания!", "Warning");
            return;
        }

        if(checkWork.CheckedItems.Count != 1)
        {
            MessageBox.Show("Нужно выбрать 1 тип работы!", "Warning");
            return;
        }

        int typeWork = checkWork.SelectedIndex;

        Work newWork = new Work();

        switch (typeWork)
        {
            case 0:
                newWork = new LabWork();
                break;
            case 1:
                newWork = new PracticalWork();
                break;
            case 2:
                newWork = new CourseWork();
                break;
            default:
                break;
        }

        newWork.Name = textBox[0].Text;
        newWork.WorkDiscription = textBox[1].Text;

        for (int i = 0; i < tasks.Count; i++)
        {
            newWork.AddTask(tasks[i]);
        }

        admin.AddWork(newWork);

        this.Close();
    }
    public void CreatedCheckList()
    {
        string[] typeWork = { "Лабараторная", "Практическая", "Курсовая" };
        
        checkWork.Items.AddRange(typeWork);
        checkWork.SelectedIndex = 0;
        
        checkWork.Location = new Point(350, 150);
        panel1.Controls.Add(checkWork);
    }
}
