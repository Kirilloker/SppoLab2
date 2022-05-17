using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SppoLab2.WindowsForm
{
    public partial class WarningUI : Form
    {

        public WarningUI()
        {
            InitializeComponent();

            CheckedListBox x = new CheckedListBox();
            string[] myFruit = { "Лабараторная", "Практическая", "Курсовая" };
            x.Items.AddRange(myFruit);
            x.SelectedIndex = 0;
            this.Controls.Add(x);
            Console.WriteLine(x.Created);
            Console.WriteLine("test");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WarningUI_Load(object sender, EventArgs e)
        {

        }
    }
}
