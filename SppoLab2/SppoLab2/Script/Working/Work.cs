using System.Collections.Generic;
namespace SppoLab2.Script.Workinging;

public class Work : GetInfo
{
    protected string name;
    protected string workDiscription;
    protected string typeWork;

    protected List<Task> listTask = new List<Task>();

    public Work(string _name, string _workDiscription, string _typeWork)
    {
        typeWork = _typeWork;
        name = _name;
        workDiscription = _workDiscription;
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
            if (value.Length <= 1 || value.Length >= 200)
            {
                UI.PrintWarning("Имя работы должно быть от 1 до 200 символов!");
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
            if (value.Length <= 1 || value.Length >= 1000)
            {
                UI.PrintWarning("Описание работы должно быть от 1 до 1 000 символов!");
            }
            else
            {
                workDiscription = value;
            }
        }
    }

    // Test Save

    public string TypeWork { get { return typeWork; } set { typeWork = value; } }
    //public List<Task> ListTask { get { return listTask; } set { listTask = value; } }

    public Task[] ListTask
    {
        get { return listTask.ToArray(); }
        set
        {
            System.Console.WriteLine("Test Set");
            List<Task> test = new List<Task>();

            for (int i = 0; i < value.Length; i++)
            {
                System.Console.WriteLine(value[i].GetFullInfo());
            }

            for (int i = 0; i < value.Length; i++)
            {
                test.Add(value[i]);
            }

            listTask = test;
        }
    }

}