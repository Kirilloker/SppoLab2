using SppoLab2.Script.Users;
using SppoLab2.WindowsForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SppoLab2.Script;

internal class PrintAllTaskUI : PrintFunctional
{
    public PrintAllTaskUI(String _mainLabel, List<GetInfo> _labels, Admin _admin) : base(_mainLabel, _labels, _admin)
    {
        CreateButtonInPanel("Удалить", DeleteTask);
    }

    private void DeleteTask(object sender, EventArgs e)
    {
        int countTask = (int)((Control)sender).Tag;
        admin.DeleteTask(countTask);

        var newForm = new PrintAllTaskUI(MainLabel.Text, new List<GetInfo>(admin.GetListTasks()), admin);
        newForm.Show();
        this.Close();
    }
}
