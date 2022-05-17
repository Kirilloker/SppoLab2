using SppoLab2.Script.Workinging;

namespace SppoLab2.Script.Working.WorkCreator;

public class CourseWorkBuilder : WorkBuilder
{
    public CourseWorkBuilder()
    {
        work = new CourseWork();
    }

    public void Reset()
    {
        work = new CourseWork();
    }
}