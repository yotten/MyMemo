﻿namespace MyMemo
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxMain = new System.Windows.Forms.TextBox();
            this.MenuItemFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.MenuItemSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFontSettingFont = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemFile,
            this.MenuItemSetting});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuItemFile
            // 
            this.MenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemFileNew,
            this.MenuItemFileOpen,
            this.MenuItemFileSave,
            this.MenuItemFileSaveAs,
            this.toolStripSeparator1,
            this.MenuItemFileExit});
            this.MenuItemFile.Name = "MenuItemFile";
            this.MenuItemFile.Size = new System.Drawing.Size(85, 22);
            this.MenuItemFile.Text = "ファイル(&F)";
            // 
            // MenuItemFileExit
            // 
            this.MenuItemFileExit.Name = "MenuItemFileExit";
            this.MenuItemFileExit.Size = new System.Drawing.Size(201, 22);
            this.MenuItemFileExit.Text = "終了(&X)";
            this.MenuItemFileExit.Click += new System.EventHandler(this.MenuItemFileExit_Click);
            // 
            // textBoxMain
            // 
            this.textBoxMain.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxMain.Location = new System.Drawing.Point(53, 49);
            this.textBoxMain.Name = "textBoxMain";
            this.textBoxMain.Size = new System.Drawing.Size(100, 23);
            this.textBoxMain.TabIndex = 1;
            this.textBoxMain.TextChanged += new System.EventHandler(this.textBoxMain_TextChanged);
            // 
            // MenuItemFileNew
            // 
            this.MenuItemFileNew.Name = "MenuItemFileNew";
            this.MenuItemFileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.MenuItemFileNew.Size = new System.Drawing.Size(201, 22);
            this.MenuItemFileNew.Text = "新規(&N)";
            this.MenuItemFileNew.Click += new System.EventHandler(this.MenuItemFileNew_Click);
            // 
            // MenuItemFileOpen
            // 
            this.MenuItemFileOpen.Name = "MenuItemFileOpen";
            this.MenuItemFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.MenuItemFileOpen.Size = new System.Drawing.Size(201, 22);
            this.MenuItemFileOpen.Text = "開く(O)";
            this.MenuItemFileOpen.Click += new System.EventHandler(this.MenuItemFileOpen_Click);
            // 
            // MenuItemFileSave
            // 
            this.MenuItemFileSave.Name = "MenuItemFileSave";
            this.MenuItemFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.MenuItemFileSave.Size = new System.Drawing.Size(201, 22);
            this.MenuItemFileSave.Text = "上書き保存(&S)";
            this.MenuItemFileSave.Click += new System.EventHandler(this.MenuItemFileSave_Click);
            // 
            // MenuItemFileSaveAs
            // 
            this.MenuItemFileSaveAs.Name = "MenuItemFileSaveAs";
            this.MenuItemFileSaveAs.Size = new System.Drawing.Size(201, 22);
            this.MenuItemFileSaveAs.Text = "名前を付けて保存(&A)";
            this.MenuItemFileSaveAs.Click += new System.EventHandler(this.MenuItemFileSaveAs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(198, 6);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MenuItemSetting
            // 
            this.MenuItemSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemFontSettingFont});
            this.MenuItemSetting.Name = "MenuItemSetting";
            this.MenuItemSetting.Size = new System.Drawing.Size(62, 22);
            this.MenuItemSetting.Text = "設定(&S)";
            // 
            // MenuItemFontSettingFont
            // 
            this.MenuItemFontSettingFont.Name = "MenuItemFontSettingFont";
            this.MenuItemFontSettingFont.Size = new System.Drawing.Size(152, 22);
            this.MenuItemFontSettingFont.Text = "フォント";
            this.MenuItemFontSettingFont.Click += new System.EventHandler(this.MenuItemFontSettingFont_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.textBoxMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFileExit;
        private System.Windows.Forms.TextBox textBoxMain;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFileNew;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFileOpen;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFileSave;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFileSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSetting;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFontSettingFont;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}

