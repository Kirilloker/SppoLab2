using System.Collections.Generic;

namespace SppoLab2.Script.Workinging;

class LabWork : Work
{
    public LabWork(string _name, string _workDiscription)
        : base(_name, _workDiscription, "Лабараторная работа") { }

    public LabWork() : base()
    {
        typeWork = "Лабараторная работа";
        listTask = new List<Task>();
    }
}
