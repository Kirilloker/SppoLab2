using SppoLab2.Script.Courses;
using System.Collections.Generic;

namespace SppoLab2.Script.Users;

public class Student : GetInfo
{
    private List<Course> myCourse = new List<Course>();
    public string name { get; private set; }
    public string group { get; private set; }
    

    public Student(string _name, string _group)
    {
        name = _name;
        group = _group;
    }

    public string GetFullInfo()
    {
        return ("Студент\n" +
                "Имя: " + name + "\n" +
                "Группа: " + group + "\n"
                );
    }

    public string GetShortInfo()
    {
        return name;
    }

    public void UnsubscribeCourse(Course course)
    {
        myCourse.Remove(course);
    }

    public void AddCourse(Course _course)
    {
        myCourse.Add(_course);
    }

    public List<Course> GetListCourse()
    {
        return myCourse;
    }
}