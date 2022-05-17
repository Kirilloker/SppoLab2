using SppoLab2.Script.Users;
using SppoLab2.Script.Workinging;
using SppoLab2.WindowsForm;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SppoLab2.Script;

internal class CreateStudent : PrintFunctional
{
    public CreateStudent(String _mainLabel, List<GetInfo> _labels, Admin _admin) : base(_mainLabel, _labels, _admin)
    {
        CreateTextBox();
        CreateButton("Зарегистрировать", RegistrationStudent);
    }

    public void RegistrationStudent(object sender, EventArgs e)
    {

        if (textBox[0].Text == "" || textBox[1].Text == "")
        {
            MessageBox.Show("Какое-то поле не заполнено!", "Warning");
        }
        else
        {
            admin.CreateNewStudent(textBox[0].Text, textBox[1].Text);
            this.Close();
        }
    }

}
