using SppoLab2.Script.Users;
using SppoLab2.Script.Workinging;
using SppoLab2.WindowsForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SppoLab2.Script;

internal class PrintAllCourseUI : PrintFunctional
{
    public PrintAllCourseUI(String _mainLabel, List<GetInfo> _labels, Admin _admin) : base(_mainLabel, _labels, _admin)
    {
        CreateButtonInPanel("Подробнее", DeepPrintCourse);
        CreateButtonInPanel("Удалить", DeleteCourse);
    }

    private void DeleteCourse(object sender, EventArgs e)
    {
        int countCourse= (int)((Control)sender).Tag;
        admin.DeleteCourse(countCourse);

        var newForm = new PrintAllCourseUI(MainLabel.Text, new List<GetInfo>(admin.GetListCourse()), admin);
        newForm.Show();
        this.Close();
    }

    private void DeepPrintCourse(object sender, EventArgs e)
    {
        int countCourse= (int)((Control)sender).Tag;
        var newForm = new PrintAllCourseUI(admin.GetListCourse()[countCourse].GetFullInfo(), new List<GetInfo>(), admin);
        newForm.Show();
    }
}
