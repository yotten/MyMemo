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
        const string RegistryKey = "Software" + ApplicationName;
        private string FilePath;
        private string FileNameValue;
        private string FileName
        {
            get { return FileNameValue; }
            set {
                FileNameValue = value;
                if (value != "")
                    FilePath = System.IO.Path.GetDirectoryName(value);
                Edited = false;
            }
        }

        private bool EditedValue;
        private bool Edited
        {
            get { return EditedValue; }
            set {
                EditedValue = value;
                UpdateStatus();
            }
        }

        private void UpdateStatus()
        {
            string s = ApplicationName;

            if (FileName != "")
                s += " - " + FileName;
            if (Edited)
                s += "（変更あり）";
            this.Text = s;

            if (FileName == "" || !Edited || textBoxMain.TextLength == 0)
                MenuItemFileSave.Enabled = false;
            else
                MenuItemFileSave.Enabled = true;

            if (!Edited || textBoxMain.TextLength == 0)
                MenuItemFileSaveAs.Enabled = false;
            else
                MenuItemFileSaveAs.Enabled = true;

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            const int initialWidth = 400;
            const int initialHeight = 200;

            this.MinimumSize = new System.Drawing.Size(initialWidth, initialHeight);

            FileName = "";

            textBoxMain.Multiline = true;
            textBoxMain.ScrollBars = ScrollBars.Vertical;
            textBoxMain.Dock = DockStyle.Fill;

            fontDialog1.ShowEffects = false; // 文字飾りをfalse
            fontDialog1.AllowScriptChange = false; // 文字セットをfalse

            saveFileDialog1.Filter = "テキスト文書|*.txt|すべてのファイル|*.*";

            // レジストリからFilePathを取り出す。レジストリにFilePathが無い場合は「マイ ドキュメント」を入れる
            Microsoft.Win32.RegistryKey regKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(RegistryKey);
            FilePath = regKey.GetValue("FilePath", System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)).ToString();

            string name = regKey.GetValue("FontName", "MS ゴシック").ToString();
            Single size = Single.Parse(regKey.GetValue("FontSize", 12).ToString());
            bool bold = bool.Parse(regKey.GetValue("FontBold", false).ToString());
            bool italic = bool.Parse(regKey.GetValue("FontItalic", false).ToString());
            System.Drawing.FontStyle style = new System.Drawing.FontStyle();

            if (bold)
                style = System.Drawing.FontStyle.Bold;
            if (italic)
                style = style ^ System.Drawing.FontStyle.Italic;
            textBoxMain.Font = new System.Drawing.Font(name, size, style);
                

            if (Environment.GetCommandLineArgs().Length > 1)
            {
                string[] args = Environment.GetCommandLineArgs();
                LoadFile(args[1]);
            }
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

        private void LoadFile(string path)
        {
            if (!System.IO.File.Exists(path))
            {
                MessageBox.Show(path + "が見つかりません", ApplicationName);
                return;
            }
             
            textBoxMain.Text = System.IO.File.ReadAllText(path, System.Text.Encoding.GetEncoding("Shift_JIS"));
            FileName = path;
            textBoxMain.Select(0, 0);
        }

        private void MenuItemFileSaveAs_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = FilePath;
            saveFileDialog1.FileName = System.IO.Path.GetFileName(FileName);

            if (DialogResult.OK == saveFileDialog1.ShowDialog())
                SaveFile(saveFileDialog1.FileName);
        }

        private void SaveFile(string value)
        {
            System.IO.File.WriteAllText(value, textBoxMain.Text, System.Text.Encoding.GetEncoding("Shift_JIS"));
            FileName = value;
        }

        private void MenuItemFileSave_Click(object sender, EventArgs e)
        {
            SaveFile(FileName);
        }

        private void textBoxMain_TextChanged(object sender, EventArgs e)
        {
            Edited = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!AskGiveUpText())
                e.Cancel = true;
        }

        private bool AskGiveUpText()
        {
            if (!Edited || textBoxMain.TextLength == 0)
                return true;

            if (DialogResult.Yes == MessageBox.Show("編集内容を破棄しますか？", ApplicationName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                return true;
            else
                return false;
        }

        private void MenuItemFileNew_Click(object sender, EventArgs e)
        {
            if (!AskGiveUpText())
                return;

            textBoxMain.Clear();
            FileName = "";
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Microsoft.Win32.RegistryKey regKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(RegistryKey);
            regKey.SetValue("FilePath", FilePath);
            regKey.SetValue("FontName", textBoxMain.Font.Name);
            regKey.SetValue("FontSize", textBoxMain.Font.Size);
            regKey.SetValue("FontBold", textBoxMain.Font.Bold);
            regKey.SetValue("FontItalic", textBoxMain.Font.Italic);
        }

        private void MenuItemFontSettingFont_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = textBoxMain.Font; // 現在の設定値を初期値に設定
            if (fontDialog1.ShowDialog() == DialogResult.OK)
                textBoxMain.Font = fontDialog1.Font;
        }
    }
}
