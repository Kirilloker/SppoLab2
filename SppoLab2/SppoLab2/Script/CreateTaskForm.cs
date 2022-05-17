using SppoLab2.Script.Users;
using SppoLab2.Script.Workinging;
using SppoLab2.WindowsForm;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SppoLab2.Script;

internal class CreateTaskForm : PrintFunctional
{
    public CreateTaskForm(String _mainLabel, List<GetInfo> _labels, Admin _admin) : base(_mainLabel, _labels, _admin)
    {
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
