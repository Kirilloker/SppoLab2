using System.Collections.Generic;
namespace SppoLab2.Script.Workinging;

public class Work : GetInfo
{
    protected string name;
    protected string workDiscription;
    protected string typeWork;
    protected List<Task> listTask;

    public Work(string _name, string _workDiscription, string _typeWork)
    {
        typeWork = _typeWork;
        name = _name;
        workDiscription = _workDiscription;
        listTask = new List<Task>();
    }

    public Work()
    {
        name = "Название работы";
        workDiscription = "Описание работы";
    }

    public string GetFullInfo()
    {
        string str =
            typeWork +
            "\n" + "'" + name + "'" + "\n" +
            "Описание: " + workDiscription + "\n" +
            "Задания:" + "\n";


        for (int i = 0; i < listTask.Count; i++)
        {
            str += "    " + (i + 1).ToString() + ". " + listTask[i].GetFullInfo() + "\n";
        }

        System.Console.WriteLine(str);
        System.Console.WriteLine("Test");
        string[] test = str.Split('\n');
        System.Console.WriteLine(test.Length);
        return str;
    }

    public string GetShortInfo()
    {
        return typeWork + ": " + name;
    }

    public void AddTask(Task _task)
    {
        listTask.Add(_task);
    }

    public string Name
    {
        get { return name; }

        set
        {
            if (value.Length <= 2 || value.Length >= 200)
            {
                UI.PrintWarning("Имя работы должно быть от 2 до 200 символов!");
            }
            else
            {
                name = value;
            }

        }
    }
    public string WorkDiscription
    {
        get { return workDiscription; }

        set
        {
            if (value.Length <= 2 || value.Length >= 1000)
            {
                UI.PrintWarning("Описание работы должно быть от 2 до 1 000 символов!");
            }
            else
            {
                workDiscription = value;
            }
        }
    }

}