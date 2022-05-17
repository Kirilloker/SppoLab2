using SppoLab2.Script;
using SppoLab2.Script.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SppoLab2.WindowsForm;

public partial class PrintFunctional : Form
{
    protected List<GetInfo> text = new List<GetInfo>();
    protected List<List<Button>> buttonsInPanel = new List<List<Button>>();
    protected List<Button> buttons = new List<Button>();
    protected List<Label> labels = new List<Label>();
    protected List<TextBox> textBox = new List<TextBox>();
    protected delegate void ButtonFunction(object sender, EventArgs e);
    protected Admin admin;
    protected Student student;

    public PrintFunctional(String _mainLabel, List<GetInfo> _text, Admin _admin, Student _student)
    {
        admin = _admin;
        student = _student;
        CreateWindows(_mainLabel, _text);
    }
    public PrintFunctional(String _mainLabel, List<GetInfo> _text, Admin _admin)
    {
        admin = _admin;
        CreateWindows(_mainLabel, _text);
    }


    public PrintFunctional(String _mainLabel, List<GetInfo> _text, Student _student)
    {
        student = _student;
        CreateWindows(_mainLabel, _text);
    }

    public PrintFunctional(String _mainLabel, List<GetInfo> _text)
    {
        InitializeComponent();

        text = _text;
        MainLabel.Text = _mainLabel;

        string[] test = _mainLabel.Split('\n');

        int xPosition = (this.Size.Width - _mainLabel.Length * 15) / 2;

        if (xPosition < 0)
        {
            xPosition = 40;
        }

        MainLabel.Location = new Point(xPosition, 10);

        CreateLabelsInPanel();
        CreateScrollBar();
    }

    public void CreateWindows(String _mainLabel, List<GetInfo> _text)
    {
        InitializeComponent();

        text = _text;
        MainLabel.Text = _mainLabel;

        string[] test = _mainLabel.Split('\n');

        int xPosition = (this.Size.Width - _mainLabel.Length * 15) / 2;

        if (xPosition < 0)
        {
            xPosition = 40;
        }

        MainLabel.Location = new Point(xPosition, 10);

        CreateLabelsInPanel();
        CreateScrollBar();
    }


    protected void CreateLabelsInPanel()
    {
        for (int i = 0; i < text.Count; i++)
        {
            Label label = new Label();
            
            label.Text = text[i].GetShortInfo();
            label.Location = new Point(10, 20 + 60 * i);
            label.Font = new Font(DefaultFont.Name, 12);
            label.Size = new Size(300,40);
            
            panel1.Controls.Add(label); 

            labels.Add(label);
        }
    }

    protected void CreateTextBox()
    {
        for (int i = 0; i < text.Count; i++)
        {
            TextBox _textBox = new TextBox();

            _textBox.Text = text[i].GetShortInfo();
            _textBox.Location = new Point(350, 20 + 60 * i);
            _textBox.Font = new Font(DefaultFont.Name, 12);
            _textBox.Size = new Size(300, 40);

            panel1.Controls.Add(_textBox);

            textBox.Add(_textBox);
        }
    }

    public void CreateScrollBar()
    {
        panel1.AutoScroll = false;
        panel1.HorizontalScroll.Enabled = false;
        panel1.HorizontalScroll.Visible = false;
        panel1.HorizontalScroll.Maximum = 0;
        panel1.AutoScroll = true;
    }

    int nicePositionInPanel = 350;
    protected void CreateButtonInPanel(string name, ButtonFunction func)
    {
        List<Button> _buttons = new List<Button>();
        int sizeWidth = name.Length * 10 + 20;

        for (int i = 0; i < labels.Count; i++)
        {
            Button button = new Button();
            button.Text = name;
            button.Location = new Point(nicePositionInPanel, 10 + 60 * i);
            button.Font = new Font(DefaultFont.Name, 10);
            button.Size = new Size(sizeWidth, 40);
            button.Tag = i;
            button.Click += new EventHandler(func);

            panel1.Controls.Add(button);

            _buttons.Add(button);
        }

        buttonsInPanel.Add(_buttons);
        nicePositionInPanel += sizeWidth + 10;
    }

    int nicePosition = 250;

    protected void CreateButton(string name, ButtonFunction func)
    {
        int sizeWidth = name.Length * 10 + 20;
        Button button = new Button();

        button.Text = name;
        button.Location = new Point(nicePosition, 440);
        button.Font = new Font(DefaultFont.Name, 10);
        button.Size = new Size(sizeWidth, 40);
        button.Tag = buttons.Count;
        button.Click += new EventHandler(func);

        this.Controls.Add(button);
        buttons.Add(button);

        nicePosition += sizeWidth + 10;
    }





    private void PrintFunctional_Load(object sender, EventArgs e)
    {
    }

    private void panel1_Paint(object sender, PaintEventArgs e)
    {

    }

    private void MainLabel_Click(object sender, EventArgs e)
    {

    }
}
