using SppoLab2.Script.Workinging;

namespace SppoLab2.Script.Working.WorkCreator;

public class LabWorkBuilder : WorkBuilder
{
    public LabWorkBuilder()
    {
        work = new LabWork();
    }

    public void Reset()
    {
        work = new LabWork();
    }

}