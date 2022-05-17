using SppoLab2.Script.Workinging;
namespace SppoLab2.Script.Working.WorkCreator;

public class PracticalWorkBuilder : WorkBuilder
{
    public PracticalWorkBuilder()
    {
        work = new PracticalWork();
    }

    public void Reset()
    {
        work = new PracticalWork();
    }
}