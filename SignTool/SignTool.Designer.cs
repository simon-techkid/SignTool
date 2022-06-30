namespace SignTool
{
    partial class Form1
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
            this.SignFolder = new System.Windows.Forms.Button();
            this.logtxt = new System.Windows.Forms.TextBox();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.menuList = new System.Windows.Forms.ToolStripDropDownButton();
            this.ButtonAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.ExitButton = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.SaveLog = new System.Windows.Forms.Button();
            this.ResetJob = new System.Windows.Forms.Button();
            this.groupBoxSigner = new System.Windows.Forms.GroupBox();
            this.JobFilesInfo = new System.Windows.Forms.Button();
            this.groupBoxFiles = new System.Windows.Forms.GroupBox();
            this.SelectAllFiles = new System.Windows.Forms.Button();
            this.ClearFiles = new System.Windows.Forms.Button();
            this.AddFolder = new System.Windows.Forms.Button();
            this.AddFile = new System.Windows.Forms.Button();
            this.FilesListBox = new System.Windows.Forms.CheckedListBox();
            this.statusBar.SuspendLayout();
            this.groupBoxSigner.SuspendLayout();
            this.groupBoxFiles.SuspendLayout();
            this.SuspendLayout();
            // 
            // SignFolder
            // 
            this.SignFolder.Location = new System.Drawing.Point(5, 18);
            this.SignFolder.Name = "SignFolder";
            this.SignFolder.Size = new System.Drawing.Size(75, 23);
            this.SignFolder.TabIndex = 7;
            this.SignFolder.Text = "Start Job";
            this.SignFolder.UseVisualStyleBackColor = true;
            this.SignFolder.Click += new System.EventHandler(this.SignFolder_Click);
            // 
            // logtxt
            // 
            this.logtxt.AcceptsReturn = true;
            this.logtxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logtxt.BackColor = System.Drawing.SystemColors.Window;
            this.logtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logtxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.logtxt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.logtxt.Location = new System.Drawing.Point(5, 43);
            this.logtxt.Multiline = true;
            this.logtxt.Name = "logtxt";
            this.logtxt.ReadOnly = true;
            this.logtxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logtxt.Size = new System.Drawing.Size(468, 94);
            this.logtxt.TabIndex = 10;
            // 
            // statusBar
            // 
            this.statusBar.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuList,
            this.progressBar,
            this.statusLabel});
            this.statusBar.Location = new System.Drawing.Point(0, 309);
            this.statusBar.Name = "statusBar";
            this.statusBar.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
            this.statusBar.Size = new System.Drawing.Size(504, 22);
            this.statusBar.TabIndex = 12;
            // 
            // menuList
            // 
            this.menuList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuList.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ButtonAbout,
            this.ButtonHelp,
            this.MenuSeparator,
            this.ExitButton});
            this.menuList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuList.Name = "menuList";
            this.menuList.Size = new System.Drawing.Size(51, 20);
            this.menuList.Text = "Menu";
            // 
            // ButtonAbout
            // 
            this.ButtonAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ButtonAbout.Name = "ButtonAbout";
            this.ButtonAbout.Size = new System.Drawing.Size(180, 22);
            this.ButtonAbout.Text = "About";
            this.ButtonAbout.Click += new System.EventHandler(this.ButtonAbout_Click);
            // 
            // ButtonHelp
            // 
            this.ButtonHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ButtonHelp.Name = "ButtonHelp";
            this.ButtonHelp.Size = new System.Drawing.Size(180, 22);
            this.ButtonHelp.Text = "Help";
            this.ButtonHelp.Click += new System.EventHandler(this.ButtonHelp_Click);
            // 
            // MenuSeparator
            // 
            this.MenuSeparator.Name = "MenuSeparator";
            this.MenuSeparator.Size = new System.Drawing.Size(177, 6);
            // 
            // ExitButton
            // 
            this.ExitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(180, 22);
            this.ExitButton.Text = "Exit";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // progressBar
            // 
            this.progressBar.Name = "progressBar";
            this.progressBar.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.progressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // SaveLog
            // 
            this.SaveLog.Location = new System.Drawing.Point(242, 18);
            this.SaveLog.Margin = new System.Windows.Forms.Padding(2);
            this.SaveLog.Name = "SaveLog";
            this.SaveLog.Size = new System.Drawing.Size(75, 23);
            this.SaveLog.TabIndex = 9;
            this.SaveLog.Text = "Save Log";
            this.SaveLog.UseVisualStyleBackColor = true;
            this.SaveLog.Click += new System.EventHandler(this.SaveLog_Click);
            // 
            // ResetJob
            // 
            this.ResetJob.Location = new System.Drawing.Point(84, 18);
            this.ResetJob.Margin = new System.Windows.Forms.Padding(2);
            this.ResetJob.Name = "ResetJob";
            this.ResetJob.Size = new System.Drawing.Size(75, 23);
            this.ResetJob.TabIndex = 8;
            this.ResetJob.Text = "Reset Job";
            this.ResetJob.UseVisualStyleBackColor = true;
            this.ResetJob.Click += new System.EventHandler(this.ResetJob_Click);
            // 
            // groupBoxSigner
            // 
            this.groupBoxSigner.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSigner.Controls.Add(this.JobFilesInfo);
            this.groupBoxSigner.Controls.Add(this.logtxt);
            this.groupBoxSigner.Controls.Add(this.SaveLog);
            this.groupBoxSigner.Controls.Add(this.ResetJob);
            this.groupBoxSigner.Controls.Add(this.SignFolder);
            this.groupBoxSigner.Location = new System.Drawing.Point(12, 154);
            this.groupBoxSigner.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxSigner.Name = "groupBoxSigner";
            this.groupBoxSigner.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxSigner.Size = new System.Drawing.Size(478, 142);
            this.groupBoxSigner.TabIndex = 6;
            this.groupBoxSigner.TabStop = false;
            this.groupBoxSigner.Text = "Signer";
            // 
            // JobFilesInfo
            // 
            this.JobFilesInfo.Location = new System.Drawing.Point(163, 18);
            this.JobFilesInfo.Name = "JobFilesInfo";
            this.JobFilesInfo.Size = new System.Drawing.Size(75, 23);
            this.JobFilesInfo.TabIndex = 11;
            this.JobFilesInfo.Text = "Job Files";
            this.JobFilesInfo.UseVisualStyleBackColor = true;
            this.JobFilesInfo.Click += new System.EventHandler(this.JobFilesInfo_Click);
            // 
            // groupBoxFiles
            // 
            this.groupBoxFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxFiles.Controls.Add(this.SelectAllFiles);
            this.groupBoxFiles.Controls.Add(this.ClearFiles);
            this.groupBoxFiles.Controls.Add(this.AddFolder);
            this.groupBoxFiles.Controls.Add(this.AddFile);
            this.groupBoxFiles.Controls.Add(this.FilesListBox);
            this.groupBoxFiles.Location = new System.Drawing.Point(12, 8);
            this.groupBoxFiles.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxFiles.Name = "groupBoxFiles";
            this.groupBoxFiles.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxFiles.Size = new System.Drawing.Size(478, 142);
            this.groupBoxFiles.TabIndex = 0;
            this.groupBoxFiles.TabStop = false;
            this.groupBoxFiles.Text = "Files";
            // 
            // SelectAllFiles
            // 
            this.SelectAllFiles.Location = new System.Drawing.Point(84, 16);
            this.SelectAllFiles.Margin = new System.Windows.Forms.Padding(2);
            this.SelectAllFiles.Name = "SelectAllFiles";
            this.SelectAllFiles.Size = new System.Drawing.Size(75, 23);
            this.SelectAllFiles.TabIndex = 2;
            this.SelectAllFiles.Text = "Deselect All";
            this.SelectAllFiles.UseVisualStyleBackColor = true;
            this.SelectAllFiles.Click += new System.EventHandler(this.SelectAllFiles_Click);
            // 
            // ClearFiles
            // 
            this.ClearFiles.Location = new System.Drawing.Point(5, 16);
            this.ClearFiles.Margin = new System.Windows.Forms.Padding(2);
            this.ClearFiles.Name = "ClearFiles";
            this.ClearFiles.Size = new System.Drawing.Size(75, 23);
            this.ClearFiles.TabIndex = 1;
            this.ClearFiles.Text = "Clear All";
            this.ClearFiles.UseVisualStyleBackColor = true;
            this.ClearFiles.Click += new System.EventHandler(this.ClearFiles_Click);
            // 
            // AddFolder
            // 
            this.AddFolder.Location = new System.Drawing.Point(163, 16);
            this.AddFolder.Margin = new System.Windows.Forms.Padding(2);
            this.AddFolder.Name = "AddFolder";
            this.AddFolder.Size = new System.Drawing.Size(75, 23);
            this.AddFolder.TabIndex = 3;
            this.AddFolder.Text = "Add Folder";
            this.AddFolder.UseVisualStyleBackColor = true;
            this.AddFolder.Click += new System.EventHandler(this.AddFolder_Click);
            // 
            // AddFile
            // 
            this.AddFile.Location = new System.Drawing.Point(242, 16);
            this.AddFile.Margin = new System.Windows.Forms.Padding(2);
            this.AddFile.Name = "AddFile";
            this.AddFile.Size = new System.Drawing.Size(75, 23);
            this.AddFile.TabIndex = 4;
            this.AddFile.Text = "Add File";
            this.AddFile.UseVisualStyleBackColor = true;
            this.AddFile.Click += new System.EventHandler(this.AddFile_Click);
            // 
            // FilesListBox
            // 
            this.FilesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FilesListBox.CheckOnClick = true;
            this.FilesListBox.FormattingEnabled = true;
            this.FilesListBox.Location = new System.Drawing.Point(5, 43);
            this.FilesListBox.Margin = new System.Windows.Forms.Padding(2);
            this.FilesListBox.Name = "FilesListBox";
            this.FilesListBox.ScrollAlwaysVisible = true;
            this.FilesListBox.Size = new System.Drawing.Size(468, 92);
            this.FilesListBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AccessibleName = "SignTool";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 331);
            this.Controls.Add(this.groupBoxFiles);
            this.Controls.Add(this.groupBoxSigner);
            this.Controls.Add(this.statusBar);
            this.MinimumSize = new System.Drawing.Size(363, 354);
            this.Name = "Form1";
            this.Text = "SignTool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.groupBoxSigner.ResumeLayout(false);
            this.groupBoxSigner.PerformLayout();
            this.groupBoxFiles.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SignFolder;
        private System.Windows.Forms.TextBox logtxt;
        private System.Windows.Forms.StatusStrip statusBar;
        public System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.Button SaveLog;
        private System.Windows.Forms.Button ResetJob;
        private System.Windows.Forms.GroupBox groupBoxSigner;
        private System.Windows.Forms.GroupBox groupBoxFiles;
        private System.Windows.Forms.Button ClearFiles;
        private System.Windows.Forms.Button AddFolder;
        private System.Windows.Forms.Button AddFile;
        private System.Windows.Forms.CheckedListBox FilesListBox;
        private System.Windows.Forms.Button SelectAllFiles;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.ToolStripDropDownButton menuList;
        private System.Windows.Forms.ToolStripMenuItem ButtonAbout;
        private System.Windows.Forms.ToolStripMenuItem ButtonHelp;
        private System.Windows.Forms.ToolStripSeparator MenuSeparator;
        private System.Windows.Forms.ToolStripMenuItem ExitButton;
        private System.Windows.Forms.Button JobFilesInfo;
    }
}

