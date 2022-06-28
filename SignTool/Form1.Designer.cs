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
            this.strip = new System.Windows.Forms.MenuStrip();
            this.stripFile = new System.Windows.Forms.ToolStripMenuItem();
            this.newJob = new System.Windows.Forms.ToolStripMenuItem();
            this.saveJob = new System.Windows.Forms.ToolStripMenuItem();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.stripAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.statusBar.SuspendLayout();
            this.strip.SuspendLayout();
            this.SuspendLayout();
            // 
            // SignFile
            // 
            this.SignFile.Location = new System.Drawing.Point(18, 38);
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
            this.SignFolder.Location = new System.Drawing.Point(138, 38);
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
            this.logtxt.Location = new System.Drawing.Point(18, 83);
            this.logtxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logtxt.Multiline = true;
            this.logtxt.Name = "logtxt";
            this.logtxt.ReadOnly = true;
            this.logtxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logtxt.Size = new System.Drawing.Size(890, 488);
            this.logtxt.TabIndex = 3;
            // 
            // statusBar
            // 
            this.statusBar.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusBar.Location = new System.Drawing.Point(0, 589);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(928, 22);
            this.statusBar.TabIndex = 4;
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 15);
            // 
            // strip
            // 
            this.strip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripFile,
            this.stripAbout});
            this.strip.Location = new System.Drawing.Point(0, 0);
            this.strip.Name = "strip";
            this.strip.Size = new System.Drawing.Size(928, 33);
            this.strip.TabIndex = 6;
            this.strip.Text = "strip";
            // 
            // stripFile
            // 
            this.stripFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newJob,
            this.saveJob,
            this.toolStripSeparator1,
            this.exit});
            this.stripFile.Name = "stripFile";
            this.stripFile.Size = new System.Drawing.Size(54, 29);
            this.stripFile.Text = "File";
            // 
            // newJob
            // 
            this.newJob.Name = "newJob";
            this.newJob.Size = new System.Drawing.Size(270, 34);
            this.newJob.Text = "New";
            this.newJob.Click += new System.EventHandler(this.NewJob_Click);
            // 
            // saveJob
            // 
            this.saveJob.Name = "saveJob";
            this.saveJob.Size = new System.Drawing.Size(270, 34);
            this.saveJob.Text = "Save As";
            this.saveJob.Click += new System.EventHandler(this.SaveJob_Click);
            // 
            // exit
            // 
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(270, 34);
            this.exit.Text = "Exit";
            this.exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // stripAbout
            // 
            this.stripAbout.Name = "stripAbout";
            this.stripAbout.Size = new System.Drawing.Size(16, 29);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(267, 6);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 611);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.strip);
            this.Controls.Add(this.logtxt);
            this.Controls.Add(this.SignFolder);
            this.Controls.Add(this.SignFile);
            this.MainMenuStrip = this.strip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(285, 250);
            this.Name = "Form1";
            this.Text = "SignTool";
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.strip.ResumeLayout(false);
            this.strip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SignFile;
        private System.Windows.Forms.Button SignFolder;
        private System.Windows.Forms.TextBox logtxt;
        private System.Windows.Forms.StatusStrip statusBar;
        public System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.MenuStrip strip;
        private System.Windows.Forms.ToolStripMenuItem stripFile;
        private System.Windows.Forms.ToolStripMenuItem newJob;
        private System.Windows.Forms.ToolStripMenuItem saveJob;
        private System.Windows.Forms.ToolStripMenuItem exit;
        private System.Windows.Forms.ToolStripMenuItem stripAbout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

