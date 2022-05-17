using SppoLab2.Script.Users;
using SppoLab2.Script.Workinging;
using SppoLab2.WindowsForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SppoLab2.Script;

internal class SubscribeCourse : SketchUI
{
    public SubscribeCourse(Student _student) 
    {
        student = _student;

        CreateWindows("Запись на курс", new List<GetInfo>(admin.GetListCourse()));

        CreateButtonInPanel("Подробнее", DeepPrintCourse);
        CreateButtonInPanel("Записаться (not protected)", SubscribeNoProtected);
        CreateButtonInPanel("Записаться (protected)", SubscribeWithProtected);
    }

    private void SubscribeWithProtected(object sender, EventArgs e)
    {
        int countCourse = (int)((Control)sender).Tag;
        bool trySubscribe = admin.GetListCourse()[countCourse].AddStudentWithProtected(student);

        if (trySubscribe == true)
        {
            MessageBox.Show("Вы успешно записались на курс!", "Warning");
        }
        else
        {
            MessageBox.Show("На курс не удалось подписаться", "Warning");
        }
    }

    private void SubscribeNoProtected(object sender, EventArgs e)
    {
        int countCourse = (int)((Control)sender).Tag;
        bool trySubscribe = admin.GetListCourse()[countCourse].AddStudentNoProtected(student);

        if (trySubscribe == true)
        {
            MessageBox.Show("Вы успешно записались на курс!", "Warning");
        }
        else
        {
            MessageBox.Show("На курс не удалось подписаться", "Warning");
        }
    }

    private void DeepPrintCourse(object sender, EventArgs e)
    {
        int countCourse = (int)((Control)sender).Tag;
        //var newForm = new PrintCourseStudent(admin.GetListCourse()[countCourse].GetFullInfo(), new List<GetInfo>(), student);
        //newForm.Show();

        //MessageBox.Show(admin.GetListCourse()[countCourse].GetFullInfo(), "Описание Курса");
        var newForm = new Print(admin.GetListCourse()[countCourse].GetFullInfo());
        newForm.Show();
    }
}
