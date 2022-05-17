using SppoLab2.Script.Workinging;

namespace SppoLab2.Script.Working.WorkCreator;

public class WorkBuilder
{
    protected Work work;

    public void AddTask(string _taskText)
    {
        work.AddTask(new Task(_taskText));
    }

    public void SetName(string _name)
    {
        work.Name = _name;
    }

    public void SetWorkDiscription(string _workDiscription)
    {
        work.WorkDiscription = _workDiscription;
    }

    public Work GetResult()
    {
        return work;
    }
}