using SppoLab2.Script.Users;
using SppoLab2.Script.Workinging;
using SppoLab2.WindowsForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SppoLab2.Script;

internal class PrintCourseStudent : PrintFunctional
{
    public PrintCourseStudent(String _mainLabel, List<GetInfo> _labels, Student _student) : base(_mainLabel, _labels, _student)
    {
        CreateButtonInPanel("Подробнее", DeepPrintCourse);
        CreateButtonInPanel("Отписаться", DeleteCourse);
    }

    private void DeleteCourse(object sender, EventArgs e)
    {
        int countCourse = (int)((Control)sender).Tag;
        //admin.DeleteCourse(countCourse);
        (student.GetListCourse()[countCourse]).DeleteStudent(student);

        var newForm = new PrintCourseStudent(MainLabel.Text, new List<GetInfo>(student.GetListCourse()), student);
        newForm.Show();
        this.Close();
    }

    private void DeepPrintCourse(object sender, EventArgs e)
    {
        int countCourse = (int)((Control)sender).Tag;
        var newForm = new PrintCourseStudent(student.GetListCourse()[countCourse].GetFullInfo(), new List<GetInfo>(), student);
        newForm.Show();
    }
}
