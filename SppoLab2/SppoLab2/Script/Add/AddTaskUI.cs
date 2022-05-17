using SppoLab2.Script.Workinging;
using SppoLab2.WindowsForm;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SppoLab2.Script;

internal class AddTaskUI : SketchUI
{
    public AddTaskUI(List<Task> _tasks)
    {
        CreateWindows("Список всех заданий", new List<GetInfo>(admin.GetListTasks()));

        CreateButtonInPanel("Добавить", AddTask);
        tasks = _tasks;
    }

    List<Task> tasks = new List<Task>();

    public void AddTask(object sender, EventArgs e)
    {
        tasks.Add(admin.GetListTasks()[(int)((Control)sender).Tag]);
        ((Control)sender).Dispose();
    }
}
