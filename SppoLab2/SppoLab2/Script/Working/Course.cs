using System.Collections.Generic;
using System.Threading;
using SppoLab2.Script.Users;
using SppoLab2.Script.Workinging;

namespace SppoLab2.Script.Courses;

public class Course:  GetInfo, System.IDisposable
{
    private string name;
    private string сourseDiscription;
    private List<Work> works = new List<Work>();
    private int freePlace;
    private List<Student> subscribeStudents = new List<Student>();

    private readonly ReaderWriterLockSlim m_lock =
    new ReaderWriterLockSlim(LockRecursionPolicy.NoRecursion);

    public Course(string _name, string _CourseDiscritption, int _freePlace)
    {
        name = _name;
        сourseDiscription = _CourseDiscritption;
        freePlace = _freePlace;
    }

    public string GetFullInfo()
    {
        m_lock.EnterReadLock();
        Thread.Sleep(5000);
        string str =
            "Дисциплина:" + "'" + name + "'" + "\n\n" +
            "Описание: " + сourseDiscription + "\n\n" +
            "Количество свободных мест: " + freePlace + "\n\n" +
            "Работы:" + "\n";

        for (int i = 0; i < works.Count; i++)
        {
            str += "    " + (i + 1).ToString() + ". " + works[i].GetFullInfo() + "\n";
        }

        if (subscribeStudents.Count > 0)
        {
            str += "\n\nНа курс подписаны:\n";
            for (int i = 0; i < subscribeStudents.Count; i++)
            {
                str += "\t" + subscribeStudents[i].GetShortInfo();
            }
            
        }

        str += "\n\n";
        m_lock.ExitReadLock();
        return str;
    }

    public string GetShortInfo()
    {
        return name;
    }

    public void AddWork(Work _work)
    {
        if (works.Contains(_work))
        {
            UI.PrintWarning("Такая работа уже добавлена в курс!");
            return;
        }

        works.Add(_work);
    }

    public bool AddStudentWithProtected(Student student)
    {
        m_lock.EnterWriteLock();
       
        if (freePlace <= 0)
        {
            System.Console.WriteLine("мест уже нет");
            m_lock.ExitWriteLock();
            return false;
        }

        // Симуляция сложного алгоритма хэширования который нужен чтобы записать студента на курс
        Thread.Sleep(5000);

        if (subscribeStudents.Contains(student) == false)
        {
            subscribeStudents.Add(student);
            student.AddCourse(this);

            freePlace--;
            m_lock.ExitWriteLock();
            return true;
        }

        m_lock.ExitWriteLock();
        return false;
        
    }

    public bool AddStudentNoProtected(Student student)
    {
        if (freePlace <= 0)
        {
            System.Console.WriteLine("мест уже нет");
            return false;
        }

        if (subscribeStudents.Contains(student) == false)
        {
            subscribeStudents.Add(student);
            student.AddCourse(this);

            // Симуляция сложного алгоритма хэширования который нужен чтобы записать студента на курс
            Thread.Sleep(5000);

            freePlace--;
            return true;
        }

        return false;
    }

    public void DeleteStudent(Student student)
    {
        if (subscribeStudents.Contains(student) == true)
        {
            subscribeStudents.Remove(student);
            student.UnsubscribeCourse(this);

            freePlace++;
        }
    }

    public void Dispose() { m_lock.Dispose(); }
}