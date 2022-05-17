using SppoLab2.Script.Courses;
using SppoLab2.Script.Users;
using SppoLab2.WindowsForm;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SppoLab2.Script;

internal class PrintAllStudentsUI : SketchUI
{
    public PrintAllStudentsUI() 
    {
        CreateWindows("Список всех студентов", new List<GetInfo>(admin.GetListStudents()));

        CreateButtonInPanel("Подробнее", DeepPrintStudent);
        CreateButtonInPanel("Удалить", DeleteStudent);
    }

    private void DeepPrintStudent(object sender, EventArgs e)
    {
        int numberStundent = (int)((Control)sender).Tag;
        string text = admin.GetListStudents()[numberStundent].GetFullInfo();

        var newWindow = new Print(text);
        newWindow.Show();
    }

    private void DeleteStudent(object sender, EventArgs e)
    {
        int numberStundent = (int)((Control)sender).Tag;
        admin.DeleteStudent(numberStundent);

        var newForm = new PrintAllStudentsUI();
        newForm.Show();

        this.Close();
    }
}
