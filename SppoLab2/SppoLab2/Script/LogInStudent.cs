using SppoLab2.Script.Users;
using SppoLab2.Script.Workinging;
using SppoLab2.WindowsForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SppoLab2.Script;

internal class LogInStudent : PrintFunctional
{
    public LogInStudent(String _mainLabel, List<GetInfo> _labels, Admin _admin) : base(_mainLabel, _labels, _admin)
    {
        CreateButtonInPanel("Войти", InputStudent);
    }

    private void InputStudent(object sender, EventArgs e)
    {
        int countCourse = (int)((Control)sender).Tag;
        var newForm = new StudentUI(admin.GetListStudents()[countCourse], admin);
        newForm.Show();
    }
}
