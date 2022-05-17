using SppoLab2.Script.Users;
using SppoLab2.Script.Workinging;
using SppoLab2.WindowsForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SppoLab2.Script;

internal class PrintCourseStudentUI : SketchUI
{
    public PrintCourseStudentUI(Student _student) 
    {
        student = _student;

        CreateWindows("Список всех курсов", new List<GetInfo>(student.GetListCourse()));

        CreateButtonInPanel("Подробнее", DeepPrintCourse);
        CreateButtonInPanel("Отписаться", DeleteCourse);
    }

    private void DeleteCourse(object sender, EventArgs e)
    {
        int countCourse = (int)((Control)sender).Tag;
        (student.GetListCourse()[countCourse]).DeleteStudent(student);

        var newForm = new PrintCourseStudentUI(student);
        newForm.Show();

        this.Close();
    }

    private void DeepPrintCourse(object sender, EventArgs e)
    {
        int countCourse = (int)((Control)sender).Tag;
        //var newForm = new PrintCourseStudentUI(student.GetListCourse()[countCourse].GetFullInfo(), new List<GetInfo>(), student);
        //newForm.Show();
        //MessageBox.Show(student.GetListCourse()[countCourse].GetFullInfo(), "Описание курса");
        var newForm = new Print(student.GetListCourse()[countCourse].GetFullInfo());
        newForm.Show();
    }
}
