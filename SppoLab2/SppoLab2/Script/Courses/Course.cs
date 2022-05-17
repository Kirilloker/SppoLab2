using System.Collections.Generic;
using System.Threading;
using SppoLab2.Script.Users;
using SppoLab2.Script.Workinging;

namespace SppoLab2.Script.Courses;

public class Course :  GetInfo, ICourse
{
    private string name;
    private string сourseDiscription;
    private List<Work> works = new List<Work>();
    private List<Student> students = new List<Student>();
    private int freePlace;

    public Course(string _name, string _CourseDiscritption, int _freePlace)
    {
        name = _name;
        сourseDiscription = _CourseDiscritption;
        works = new List<Work>();
        freePlace = _freePlace;
    }

    public Course()
    {
        name = "";
        сourseDiscription = "";
        works = new List<Work>();
    }

    public string GetFullInfo()
    {
        string str =
            "Дисциплина:" + "'" + name + "'" + "\n" +
            "Описание: " + сourseDiscription + "\n" +
            "Количество свободных мест: " + freePlace + "\n" +
            "Работы:" + "\n";

        for (int i = 0; i < works.Count; i++)
        {
            str += "    " + (i + 1).ToString() + ". " + works[i].GetFullInfo() + "\n";
        }

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

    public Course SelectCourse()
    {
        return this;
    }

    public void PrintDetails()
    {
        string str = "Введите номер работы которую хотите просмотреть подробнее (0 чтобы вернуться назад)";
        while (true)
        {
            UI.Clear();
            UI.Print(GetFullInfo());

            int inputUser = UI.InputSecurityRangeInt(0, works.Count, str);

            if (inputUser == 0)
            {
                return;
            }

            UI.Print(works[inputUser - 1].GetFullInfo());

            UI.Print("(нажмите любую кнопку чтобы вернуться назад)");

            UI.Ready();
        }
    }

    public bool AddStudent(Student student)
    {

        if (freePlace <= 0)
        {
            System.Console.WriteLine("мест уже нет");
            return false;
        }

        if (!students.Contains(student))
        {
            students.Add(student);
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
        if (students.Contains(student))
        {
            students.Remove(student);
            student.DeleteCourse(this);
            freePlace++;
        }
    }
    public string Name
    {
        get { return name; }

        set
        {
            if (value.Length <= 2 || value.Length >= 200)
            {
                UI.PrintWarning("Имя курса должно быть от 2 до 200 символов!");
            }
            else
            {
                name = value;
            }

        }
    }

    public string CourseDiscription
    {
        get { return сourseDiscription; }

        set
        {
            if (value.Length <= 2 || value.Length >= 1000)
            {
                UI.PrintWarning("Описание курса должно быть от 2 до 1 000 символов!");
            }
            else
            {
                сourseDiscription = value;
            }
        }
    }

}