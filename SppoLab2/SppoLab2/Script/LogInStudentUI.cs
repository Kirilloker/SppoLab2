using SppoLab2.Script.Users;
using SppoLab2.Script.Workinging;
using SppoLab2.WindowsForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SppoLab2.Script;

internal class LogInStudentUI : SketchForm
{
    public LogInStudentUI()
    {
        CreateWindows("Авторизация студента", new List<GetInfo>(Admin.getInstance().GetListStudents()));

        CreateButtonInPanel("Войти", InputStudent);
    }

    private void InputStudent(object sender, EventArgs e)
    {
        int countCourse = (int)((Control)sender).Tag;
        var newForm = new StudentUI(admin.GetListStudents()[countCourse], admin);
        newForm.Show();
    }
}
