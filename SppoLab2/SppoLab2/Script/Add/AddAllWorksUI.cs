using SppoLab2.Script;
using SppoLab2.Script.Users;
using SppoLab2.Script.Workinging;
using SppoLab2.WindowsForm;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace SppoLab2.Script;

internal class AddAllWorksUI : SketchUI
{
    public AddAllWorksUI(List<Work> _works)
    {
        CreateWindows("Список всех работ", new List<GetInfo>(admin.GetListWork()));

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
