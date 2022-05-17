using System.Collections.Generic;


namespace SppoLab2.Script.Workinging;

public class CourseWork : Work
{
    public CourseWork(string _name, string _workDiscription)
    : base(_name, _workDiscription, "Курсовая работа") { }

    public CourseWork()
    {
        typeWork = "Курсовая работа";
        listTask = new List<Task>();
    }
}
