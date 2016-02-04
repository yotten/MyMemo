using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMemo
{
    public partial class Form1 : Form
    {
        const string ApplicationName = "MyMemo";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = ApplicationName;

            textBoxMain.Multiline = true;
            textBoxMain.ScrollBars = ScrollBars.Vertical;
            textBoxMain.Dock = DockStyle.Fill;
        }

        private void MenuItemFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuItemFileOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            LoadFile(openFileDialog1.FileName);
        }

        private void LoadFile(string value)
        {
            textBoxMain.Text = System.IO.File.ReadAllText(value, System.Text.Encoding.GetEncoding("Shift_JIS"));
        }
    }
}
