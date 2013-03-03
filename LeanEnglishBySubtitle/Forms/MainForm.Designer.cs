﻿namespace Studyzy.LeanEnglishBySubtitle.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbSubtitleFilePath = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnParse = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnRemark = new System.Windows.Forms.Button();
            this.btnSyncNewWords = new System.Windows.Forms.Button();
            this.txbUserId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.字典设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemRemoveChinese = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAdjustSubtitleTimeline = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.捐赠ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.numUserVocabularyRank = new System.Windows.Forms.NumericUpDown();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUserVocabularyRank)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpenFile.Location = new System.Drawing.Point(592, 31);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(36, 23);
            this.btnOpenFile.TabIndex = 0;
            this.btnOpenFile.Text = "...";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "字幕文件：";
            // 
            // txbSubtitleFilePath
            // 
            this.txbSubtitleFilePath.Location = new System.Drawing.Point(83, 33);
            this.txbSubtitleFilePath.Name = "txbSubtitleFilePath";
            this.txbSubtitleFilePath.Size = new System.Drawing.Size(503, 21);
            this.txbSubtitleFilePath.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Srt Files|*.srt|All Files|*.*";
            // 
            // btnParse
            // 
            this.btnParse.Location = new System.Drawing.Point(648, 31);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(75, 23);
            this.btnParse.TabIndex = 3;
            this.btnParse.Text = "解析";
            this.btnParse.UseVisualStyleBackColor = true;
            this.btnParse.Click += new System.EventHandler(this.btnParse_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 167);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(711, 452);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // btnRemark
            // 
            this.btnRemark.Location = new System.Drawing.Point(648, 72);
            this.btnRemark.Name = "btnRemark";
            this.btnRemark.Size = new System.Drawing.Size(75, 23);
            this.btnRemark.TabIndex = 6;
            this.btnRemark.Text = "注释字幕";
            this.btnRemark.UseVisualStyleBackColor = true;
            this.btnRemark.Click += new System.EventHandler(this.btnRemark_Click);
            // 
            // btnSyncNewWords
            // 
            this.btnSyncNewWords.Location = new System.Drawing.Point(207, 70);
            this.btnSyncNewWords.Name = "btnSyncNewWords";
            this.btnSyncNewWords.Size = new System.Drawing.Size(90, 23);
            this.btnSyncNewWords.TabIndex = 7;
            this.btnSyncNewWords.Text = "读取词场数据";
            this.btnSyncNewWords.UseVisualStyleBackColor = true;
            this.btnSyncNewWords.Click += new System.EventHandler(this.btnSyncNewWords_Click);
            // 
            // txbUserId
            // 
            this.txbUserId.Location = new System.Drawing.Point(83, 72);
            this.txbUserId.Name = "txbUserId";
            this.txbUserId.Size = new System.Drawing.Size(100, 21);
            this.txbUserId.TabIndex = 8;
            this.txbUserId.Text = "11009764";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "沪江Id：";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 622);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(735, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(152, 17);
            this.toolStripStatusLabel1.Text = "欢迎使用深蓝英语字幕助手";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.设置ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(735, 25);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.字典设置ToolStripMenuItem});
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.设置ToolStripMenuItem.Text = "设置";
            // 
            // 字典设置ToolStripMenuItem
            // 
            this.字典设置ToolStripMenuItem.Name = "字典设置ToolStripMenuItem";
            this.字典设置ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.字典设置ToolStripMenuItem.Text = "字典设置";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemRemoveChinese,
            this.ToolStripMenuItemAdjustSubtitleTimeline,
            this.帮助ToolStripMenuItem1,
            this.捐赠ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // ToolStripMenuItemRemoveChinese
            // 
            this.ToolStripMenuItemRemoveChinese.Name = "ToolStripMenuItemRemoveChinese";
            this.ToolStripMenuItemRemoveChinese.Size = new System.Drawing.Size(148, 22);
            this.ToolStripMenuItemRemoveChinese.Text = "中文字幕删除";
            this.ToolStripMenuItemRemoveChinese.Click += new System.EventHandler(this.ToolStripMenuItemRemoveChinese_Click);
            // 
            // ToolStripMenuItemAdjustSubtitleTimeline
            // 
            this.ToolStripMenuItemAdjustSubtitleTimeline.Name = "ToolStripMenuItemAdjustSubtitleTimeline";
            this.ToolStripMenuItemAdjustSubtitleTimeline.Size = new System.Drawing.Size(148, 22);
            this.ToolStripMenuItemAdjustSubtitleTimeline.Text = "字幕时间调整";
            // 
            // 帮助ToolStripMenuItem1
            // 
            this.帮助ToolStripMenuItem1.Name = "帮助ToolStripMenuItem1";
            this.帮助ToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.帮助ToolStripMenuItem1.Text = "帮助";
            // 
            // 捐赠ToolStripMenuItem
            // 
            this.捐赠ToolStripMenuItem.Name = "捐赠ToolStripMenuItem";
            this.捐赠ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.捐赠ToolStripMenuItem.Text = "捐赠";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(323, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "用户词频等级：";
            // 
            // numUserVocabularyRank
            // 
            this.numUserVocabularyRank.Location = new System.Drawing.Point(406, 70);
            this.numUserVocabularyRank.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numUserVocabularyRank.Name = "numUserVocabularyRank";
            this.numUserVocabularyRank.Size = new System.Drawing.Size(37, 21);
            this.numUserVocabularyRank.TabIndex = 13;
            this.numUserVocabularyRank.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 644);
            this.Controls.Add(this.numUserVocabularyRank);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbUserId);
            this.Controls.Add(this.btnSyncNewWords);
            this.Controls.Add(this.btnRemark);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnParse);
            this.Controls.Add(this.txbSubtitleFilePath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpenFile);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "深蓝英语字幕助手";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUserVocabularyRank)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbSubtitleFilePath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnParse;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnRemark;
        private System.Windows.Forms.Button btnSyncNewWords;
        private System.Windows.Forms.TextBox txbUserId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemRemoveChinese;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 捐赠ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAdjustSubtitleTimeline;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numUserVocabularyRank;
        private System.Windows.Forms.ToolStripMenuItem 字典设置ToolStripMenuItem;
    }
}
