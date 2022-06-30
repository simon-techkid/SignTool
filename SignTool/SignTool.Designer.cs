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
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.SaveLog = new System.Windows.Forms.Button();
            this.ResetJob = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.groupBoxSigner = new System.Windows.Forms.GroupBox();
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
            this.SignFolder.Location = new System.Drawing.Point(7, 29);
            this.SignFolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SignFolder.Name = "SignFolder";
            this.SignFolder.Size = new System.Drawing.Size(112, 35);
            this.SignFolder.TabIndex = 1;
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
            this.logtxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.logtxt.Location = new System.Drawing.Point(7, 74);
            this.logtxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logtxt.Multiline = true;
            this.logtxt.Name = "logtxt";
            this.logtxt.ReadOnly = true;
            this.logtxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logtxt.Size = new System.Drawing.Size(876, 142);
            this.logtxt.TabIndex = 4;
            // 
            // statusBar
            // 
            this.statusBar.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusBar.Location = new System.Drawing.Point(0, 529);
            this.statusBar.Name = "statusBar";
            this.statusBar.Padding = new System.Windows.Forms.Padding(2, 0, 14, 0);
            this.statusBar.Size = new System.Drawing.Size(928, 22);
            this.statusBar.TabIndex = 6;
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 15);
            // 
            // SaveLog
            // 
            this.SaveLog.Location = new System.Drawing.Point(246, 29);
            this.SaveLog.Name = "SaveLog";
            this.SaveLog.Size = new System.Drawing.Size(112, 35);
            this.SaveLog.TabIndex = 3;
            this.SaveLog.Text = "Save Log";
            this.SaveLog.UseVisualStyleBackColor = true;
            this.SaveLog.Click += new System.EventHandler(this.SaveLog_Click);
            // 
            // ResetJob
            // 
            this.ResetJob.Location = new System.Drawing.Point(127, 29);
            this.ResetJob.Name = "ResetJob";
            this.ResetJob.Size = new System.Drawing.Size(112, 35);
            this.ResetJob.TabIndex = 2;
            this.ResetJob.Text = "Reset Job";
            this.ResetJob.UseVisualStyleBackColor = true;
            this.ResetJob.Click += new System.EventHandler(this.ResetJob_Click);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(7, 224);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(876, 35);
            this.progressBar.Step = 1;
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 5;
            // 
            // groupBoxSigner
            // 
            this.groupBoxSigner.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSigner.Controls.Add(this.logtxt);
            this.groupBoxSigner.Controls.Add(this.SaveLog);
            this.groupBoxSigner.Controls.Add(this.ResetJob);
            this.groupBoxSigner.Controls.Add(this.progressBar);
            this.groupBoxSigner.Controls.Add(this.SignFolder);
            this.groupBoxSigner.Location = new System.Drawing.Point(18, 237);
            this.groupBoxSigner.Name = "groupBoxSigner";
            this.groupBoxSigner.Size = new System.Drawing.Size(890, 271);
            this.groupBoxSigner.TabIndex = 7;
            this.groupBoxSigner.TabStop = false;
            this.groupBoxSigner.Text = "Signer";
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
            this.groupBoxFiles.Location = new System.Drawing.Point(18, 13);
            this.groupBoxFiles.Name = "groupBoxFiles";
            this.groupBoxFiles.Size = new System.Drawing.Size(890, 218);
            this.groupBoxFiles.TabIndex = 8;
            this.groupBoxFiles.TabStop = false;
            this.groupBoxFiles.Text = "Files";
            // 
            // SelectAllFiles
            // 
            this.SelectAllFiles.Location = new System.Drawing.Point(127, 25);
            this.SelectAllFiles.Name = "SelectAllFiles";
            this.SelectAllFiles.Size = new System.Drawing.Size(112, 35);
            this.SelectAllFiles.TabIndex = 5;
            this.SelectAllFiles.Text = "Select All";
            this.SelectAllFiles.UseVisualStyleBackColor = true;
            this.SelectAllFiles.Click += new System.EventHandler(this.SelectAllFiles_Click);
            // 
            // ClearFiles
            // 
            this.ClearFiles.Location = new System.Drawing.Point(6, 25);
            this.ClearFiles.Name = "ClearFiles";
            this.ClearFiles.Size = new System.Drawing.Size(112, 35);
            this.ClearFiles.TabIndex = 3;
            this.ClearFiles.Text = "Clear All";
            this.ClearFiles.UseVisualStyleBackColor = true;
            this.ClearFiles.Click += new System.EventHandler(this.ClearFiles_Click);
            // 
            // AddFolder
            // 
            this.AddFolder.Location = new System.Drawing.Point(246, 25);
            this.AddFolder.Name = "AddFolder";
            this.AddFolder.Size = new System.Drawing.Size(112, 35);
            this.AddFolder.TabIndex = 2;
            this.AddFolder.Text = "Add Folder";
            this.AddFolder.UseVisualStyleBackColor = true;
            this.AddFolder.Click += new System.EventHandler(this.AddFolder_Click);
            // 
            // AddFile
            // 
            this.AddFile.Location = new System.Drawing.Point(364, 25);
            this.AddFile.Name = "AddFile";
            this.AddFile.Size = new System.Drawing.Size(112, 35);
            this.AddFile.TabIndex = 1;
            this.AddFile.Text = "Add File";
            this.AddFile.UseVisualStyleBackColor = true;
            this.AddFile.Click += new System.EventHandler(this.AddFile_Click);
            // 
            // FilesListBox
            // 
            this.FilesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilesListBox.FormattingEnabled = true;
            this.FilesListBox.Location = new System.Drawing.Point(7, 67);
            this.FilesListBox.Name = "FilesListBox";
            this.FilesListBox.ScrollAlwaysVisible = true;
            this.FilesListBox.Size = new System.Drawing.Size(876, 142);
            this.FilesListBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 551);
            this.Controls.Add(this.groupBoxFiles);
            this.Controls.Add(this.groupBoxSigner);
            this.Controls.Add(this.statusBar);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(536, 523);
            this.Name = "Form1";
            this.Text = "SignTool";
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
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.GroupBox groupBoxSigner;
        private System.Windows.Forms.GroupBox groupBoxFiles;
        private System.Windows.Forms.Button ClearFiles;
        private System.Windows.Forms.Button AddFolder;
        private System.Windows.Forms.Button AddFile;
        private System.Windows.Forms.CheckedListBox FilesListBox;
        private System.Windows.Forms.Button SelectAllFiles;
    }
}

