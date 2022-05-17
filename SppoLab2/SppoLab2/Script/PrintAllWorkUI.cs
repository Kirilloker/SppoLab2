using SppoLab2.Script.Users;
using SppoLab2.WindowsForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SppoLab2.Script;

internal class PrintAllWorkUI : SketchForm
{
    public PrintAllWorkUI()
    {
        CreateWindows("Список всех заданий", new List<GetInfo>(admin.GetListWork()));

        CreateButtonInPanel("Подробнее", DeepPrintWork);
        CreateButtonInPanel("Удалить", DeleteWork);
    }

    private void DeleteWork(object sender, EventArgs e)
    {
        int countWork = (int)((Control)sender).Tag;
        admin.DeleteWork(countWork);

        var newForm = new PrintAllWorkUI();
        newForm.Show();
        this.Close();
    }

    private void DeepPrintWork(object sender, EventArgs e)
    {
        int countWork = (int)((Control)sender).Tag;
        //var newForm = new PrintAllWorkUI(admin.GetListWork()[countWork].GetFullInfo(), new List<GetInfo>(), admin);
        //newForm.Show();
        MessageBox.Show(admin.GetListWork()[countWork].GetFullInfo(), "Описание работы");
    }
}
