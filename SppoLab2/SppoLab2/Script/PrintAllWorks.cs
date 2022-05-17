using SppoLab2.Script;
using SppoLab2.Script.Users;
using SppoLab2.Script.Workinging;
using SppoLab2.WindowsForm;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace SppoLab2.Script;

internal class PrintAllWorks : PrintFunctional
{
    public PrintAllWorks(List<Work> _works, String _mainLabel, List<GetInfo> _labels, Admin _admin) : base(_mainLabel, _labels, _admin)
    {
        CreateButtonInPanel("Добавить", AddWork);
        works = _works;

    }

    List<Work> works = new List<Work>();

    public void AddWork(object sender, EventArgs e)
    {
        works.Add(admin.GetListWork()[(int)((Control)sender).Tag]);
        ((Control)sender).Dispose();
    }
}
