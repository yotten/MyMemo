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
        private string FileName = "";

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

            saveFileDialog1.Filter = "テキスト文書|*.txt|すべてのファイル|*.*";
        }

        private void MenuItemFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuItemFileOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";

            if (DialogResult.OK == openFileDialog1.ShowDialog())
                LoadFile(openFileDialog1.FileName);
        }

        private void LoadFile(string value)
        {
            textBoxMain.Text = System.IO.File.ReadAllText(value, System.Text.Encoding.GetEncoding("Shift_JIS"));
            FileName = value;
        }

        private void MenuItemFileSaveAs_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = System.IO.Path.GetFileName(FileName);

            if (DialogResult.OK == saveFileDialog1.ShowDialog())
                SaveFile(saveFileDialog1.FileName);
        }

        private void SaveFile(string value)
        {
            System.IO.File.WriteAllText(value, textBoxMain.Text, System.Text.Encoding.GetEncoding("Shift_JIS"));
        }
    }
}
