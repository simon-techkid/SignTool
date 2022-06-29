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
            this.SignFile = new System.Windows.Forms.Button();
            this.SignFolder = new System.Windows.Forms.Button();
            this.logtxt = new System.Windows.Forms.TextBox();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.SaveLog = new System.Windows.Forms.Button();
            this.ResetJob = new System.Windows.Forms.Button();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // SignFile
            // 
            this.SignFile.Location = new System.Drawing.Point(18, 14);
            this.SignFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SignFile.Name = "SignFile";
            this.SignFile.Size = new System.Drawing.Size(112, 35);
            this.SignFile.TabIndex = 0;
            this.SignFile.Text = "Sign File";
            this.SignFile.UseVisualStyleBackColor = true;
            this.SignFile.Click += new System.EventHandler(this.SignFile_Click);
            // 
            // SignFolder
            // 
            this.SignFolder.Location = new System.Drawing.Point(138, 14);
            this.SignFolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SignFolder.Name = "SignFolder";
            this.SignFolder.Size = new System.Drawing.Size(112, 35);
            this.SignFolder.TabIndex = 1;
            this.SignFolder.Text = "Sign Folder";
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
            this.logtxt.Location = new System.Drawing.Point(18, 59);
            this.logtxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logtxt.Multiline = true;
            this.logtxt.Name = "logtxt";
            this.logtxt.ReadOnly = true;
            this.logtxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logtxt.Size = new System.Drawing.Size(890, 489);
            this.logtxt.TabIndex = 3;
            // 
            // statusBar
            // 
            this.statusBar.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusBar.Location = new System.Drawing.Point(0, 565);
            this.statusBar.Name = "statusBar";
            this.statusBar.Padding = new System.Windows.Forms.Padding(2, 0, 14, 0);
            this.statusBar.Size = new System.Drawing.Size(928, 22);
            this.statusBar.TabIndex = 4;
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 15);
            // 
            // SaveLog
            // 
            this.SaveLog.Location = new System.Drawing.Point(257, 14);
            this.SaveLog.Name = "SaveLog";
            this.SaveLog.Size = new System.Drawing.Size(112, 35);
            this.SaveLog.TabIndex = 7;
            this.SaveLog.Text = "Save Log";
            this.SaveLog.UseVisualStyleBackColor = true;
            this.SaveLog.Click += new System.EventHandler(this.SaveLog_Click);
            // 
            // ResetJob
            // 
            this.ResetJob.Location = new System.Drawing.Point(375, 14);
            this.ResetJob.Name = "ResetJob";
            this.ResetJob.Size = new System.Drawing.Size(112, 35);
            this.ResetJob.TabIndex = 8;
            this.ResetJob.Text = "Reset Job";
            this.ResetJob.UseVisualStyleBackColor = true;
            this.ResetJob.Click += new System.EventHandler(this.ResetJob_Click);
            // 
            // SignTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 587);
            this.Controls.Add(this.ResetJob);
            this.Controls.Add(this.SaveLog);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.logtxt);
            this.Controls.Add(this.SignFolder);
            this.Controls.Add(this.SignFile);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(522, 241);
            this.Name = "SignTool";
            this.Text = "SignTool";
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button SignFile;
        private System.Windows.Forms.Button SignFolder;
        private System.Windows.Forms.TextBox logtxt;
        private System.Windows.Forms.StatusStrip statusBar;
        public System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.Button SaveLog;
        private System.Windows.Forms.Button ResetJob;
    }
}

