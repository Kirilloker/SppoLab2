using SppoLab2.Script.Users;
using SppoLab2.WindowsForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SppoLab2.Script;

internal class CheckAllStudentsUI : PrintFunctional
{
    public CheckAllStudentsUI(String _mainLabel, List<GetInfo> _labels, Admin _admin) : base(_mainLabel, _labels, _admin)
    {
        CreateButtonInPanel("Удалить", DeleteStudent);
    }

    private void DeleteStudent(object sender, EventArgs e)
    {
        int countStundent = (int)((Control)sender).Tag;
        admin.DeleteStudent(countStundent);

        #region Что это?
        /*
         * Костыль? Да, наверное
         * Проблема в том, что кнопка запоминает свой индекс при создание
         * и не меняет его когда удаляется какой-то элемент.
         */
        #endregion

        var newForm = new CheckAllStudentsUI(MainLabel.Text, new List<GetInfo>(admin.GetListStudents()), admin);
        newForm.Show();
        this.Close();
    }
}
