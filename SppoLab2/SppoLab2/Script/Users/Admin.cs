using SppoLab2.Script.Workinging;
using SppoLab2.Script.Courses;
using System.Collections.Generic;

namespace SppoLab2.Script.Users;

public class Admin
{
    private static Admin instance;

    private Admin() { }
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

}
