using SppoLab2.Script.Workinging;
using SppoLab2.Script.Courses;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Text.Json;
using System.IO;
using System.Text.Json.Serialization;
using System.Text.Encodings.Web;
using System.Text.Unicode;

namespace SppoLab2.Script.Users;

public class Admin
{
    private static Admin instance;

    public Admin() { }
    public static Admin getInstance()
    {
        if (instance == null)
            instance = new Admin();
        return instance;
    }

    private List<Student> students = new List<Student>();

    private List<Course> course = new List<Course>();
    private List<Work>   works  = new List<Work>();
    private List<Task>   tasks  = new List<Task>();

    public void AddNewStudent(string FIOStudent, string groupStudent)
    {
        Student newStudent = new Student(
            FIOStudent,
            groupStudent);

        AddStudent(newStudent);
    }

    public List<Student> GetListStudents() { return students; }
    public List<Task>    GetListTasks() { return tasks; }
    public List<Work>    GetListWork() { return works; }
    public List<Course>  GetListCourse() { return course; }

    public void AddStudent(Student student) { students.Add(student); }
    public void AddTask(Task task) { tasks.Add(task); }
    public void AddWork(Work work) { works.Add(work); }
    public void AddCourse(Course _course) { course.Add(_course); }

    public void DeleteStudent(int countStudent) { students.RemoveAt(countStudent); }
    public void DeleteTask(int countTask) { tasks.RemoveAt(countTask); }
    public void DeleteWork(int countWork) { works.RemoveAt(countWork); }
    public void DeleteCourse(int countCourse) { course.RemoveAt(countCourse); }


    // Test Save

    public Task[] Tasks { get { return tasks.ToArray(); } 
        set
        {
            List<Task> test = new List<Task>();

            for (int i = 0; i < value.Length; i++)
            {
                test.Add(value[i]);
            }

            tasks = test;
        } 
    }

    public Work[] Works
    {
        get { return works.ToArray(); }
        set
        {
            List<Work> test = new List<Work>();

            for (int i = 0; i < value.Length; i++)
            {
                test.Add(value[i]);
            }

            works = test;
        }
    }


    public Student[] Students
    {
        get { return students.ToArray(); }
        set
        {
            List<Student> test = new List<Student>();

            for (int i = 0; i < value.Length; i++)
            {
                test.Add(value[i]);
            }

            students = test;
        }
    }


    public Course[] Course
    {
        get { return course.ToArray(); }
        set
        {
            List<Course> test = new List<Course>();

            for (int i = 0; i < value.Length; i++)
            {
                test.Add(value[i]);
            }

            course = test;
        }
    }


    public void Save()
    {
        string json = JsonConvert.SerializeObject(this, Formatting.Indented,
        new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects });

        StreamWriter file1 = File.CreateText("SaveData.json");
        System.Console.WriteLine(file1);
        file1.WriteLine(json);
        file1.Close();
    }

    public void Load()
    {
        string data = File.ReadAllText("SaveData.json");

        Admin person = JsonConvert.DeserializeObject<Admin>(data,
        new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects });

        Students = person.Students;
        Course = person.Course;
        Works = person.Works;
        Tasks = person.Tasks;
    }

}

