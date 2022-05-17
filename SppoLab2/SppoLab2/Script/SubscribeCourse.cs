using SppoLab2.Script.Users;
using SppoLab2.Script.Workinging;
using SppoLab2.WindowsForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SppoLab2.Script;

internal class SubscribeCourse : PrintFunctional
{
    public SubscribeCourse(String _mainLabel, List<GetInfo> _labels, Admin _admin, Student _student) : base(_mainLabel, _labels, _admin, _student)
    {
        CreateButtonInPanel("Подробнее", DeepPrintCourse);
        CreateButtonInPanel("Записаться", Subscribe);
    }

    private void Subscribe(object sender, EventArgs e)
    {
        int countCourse = (int)((Control)sender).Tag;
        bool x = admin.GetListCourse()[countCourse].AddStudent(student);

        if (x)
        {
            MessageBox.Show("Вы успешно записались на курс!", "Warning");
        }
        else
        {
            MessageBox.Show("На курс не удалось попдисаться", "Warning");
        }
    }

    private void DeepPrintCourse(object sender, EventArgs e)
    {
        int countCourse = (int)((Control)sender).Tag;
        var newForm = new PrintCourseStudent(admin.GetListCourse()[countCourse].GetFullInfo(), new List<GetInfo>(), student);
        newForm.Show();
    }
}
