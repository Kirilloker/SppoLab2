namespace SppoLab2.Script.Users;

using SppoLab2.Script.Courses;
using SppoLab2.Script.LearnPath;
using System.Collections.Generic;

public class Student : GetInfo
{
    public string name { get; private set; }
    public string group { get; private set; }
    //public LearnPath myLearningPath { get; private set; }

    private List<Course> myCourse = new List<Course>();

    //public Student(string _name, string _group, LearnPath _myLearningPath)
    //{
    //    name = _name;
    //    group = _group;
    //    myLearningPath = _myLearningPath;
    //}

    public Student(string _name, string _group)
    {
        name = _name;
        group = _group;

        //myLearningPath = new LearnPath(new List<Courses.ICourse>());
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

    public void DeleteCourse(Course course)
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