using SppoLab2.Script.Users;
using SppoLab2.WindowsForm;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SppoLab2.Script;

internal class PrintAllStudentsUI : SketchForm
{
    public PrintAllStudentsUI() 
    {
        CreateWindows("Список всех студентов", new List<GetInfo>(admin.GetListStudents()));

        CreateButtonInPanel("Удалить", DeleteStudent);
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
