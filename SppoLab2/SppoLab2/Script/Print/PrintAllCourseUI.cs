using SppoLab2.Script.Users;
using SppoLab2.Script.Workinging;
using SppoLab2.WindowsForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SppoLab2.Script;

internal class PrintAllCourseUI : SketchUI
{
    public PrintAllCourseUI() 
    {
        CreateWindows("Список всех курсов", new List<GetInfo>(admin.GetListCourse()));

        CreateButtonInPanel("Подробнее", DeepPrintCourse);
        CreateButtonInPanel("Удалить", DeleteCourse);
    }

    private void DeleteCourse(object sender, EventArgs e)
    {
        int countCourse= (int)((Control)sender).Tag;
        admin.DeleteCourse(countCourse);

        var newForm = new PrintAllCourseUI();
        newForm.Show();

        this.Close();
    }

    private void DeepPrintCourse(object sender, EventArgs e)
    {
        int countCourse= (int)((Control)sender).Tag;
        //var newForm = new PrintAllCourseUI(admin.GetListCourse()[countCourse].GetFullInfo(), new List<GetInfo>(), admin);
        //newForm.Show();
        //MessageBox.Show(admin.GetListCourse()[countCourse].GetFullInfo(), "Описание курса");
        var newForm = new Print(admin.GetListCourse()[countCourse].GetFullInfo());
        newForm.Show();
    }
}
