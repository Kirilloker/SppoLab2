using SppoLab2.Script.Courses;
using System.Collections.Generic;

namespace SppoLab2.Script.Users;

public class Student : GetInfo
{
    private List<Course> myCourse = new List<Course>();

    private string name;
    private string group;
    

    public Student(string _name, string _group)
    {
        name = _name;
        group = _group;
    }

    public string GetFullInfo()
    {
        string str = ("Студент\n" +
                "Имя: " + name + "\n" +
                "Группа: " + group + "\n"
                );

        if (myCourse.Count > 0)
        {
            str += "\n\nПодписан на курсы:\n";
            for (int i = 0; i < myCourse.Count; i++)
            {
                str += myCourse[i].GetShortInfo();
            }
        }

        return str;
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

    // Test Save

    public string Name { get { return name; } set { name = value; } }
    public string Group { get { return group; } set { group = value; } }
    //public List<Course> MyCourse { get { return myCourse; } set { myCourse = value; } }

    public Course[] MyCourse
    {
        get { return myCourse.ToArray(); }
        set
        {
            List<Course> test = new List<Course>();

            for (int i = 0; i < value.Length; i++)
            {
                test.Add(value[i]);
            }

            myCourse = test;
        }
    }

    public Student()
    {
        name = "Пусто";
        group = "Пусто";
    }
}