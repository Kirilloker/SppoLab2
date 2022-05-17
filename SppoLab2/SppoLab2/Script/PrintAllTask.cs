using SppoLab2.Script;
using SppoLab2.Script.Users;
using SppoLab2.Script.Workinging;
using SppoLab2.WindowsForm;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace SppoLab2.Script;

internal class PrintAllTask : PrintFunctional
{
    public PrintAllTask(List<Task> _tasks, String _mainLabel, List<GetInfo> _labels, Admin _admin) : base(_mainLabel, _labels, _admin)
    {
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
