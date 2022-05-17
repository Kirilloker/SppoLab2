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
    public partial class Print : Form
    {
        public Print(string text)
        {
            InitializeComponent();
            label1.Text = text;

            this.AutoScroll = false;
            this.HorizontalScroll.Enabled = false;
            this.HorizontalScroll.Visible = false;
            this.HorizontalScroll.Maximum = 0;

            //this.VerticalScroll.Enabled = false;
            //this.VerticalScroll.Visible = false;
            //this.VerticalScroll.Maximum = 0;

            this.AutoScroll = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
