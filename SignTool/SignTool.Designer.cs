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
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar.SuspendLayout();
            this.strip.SuspendLayout();
            this.SuspendLayout();
            // 
            // SignFile
            // 
            this.SignFile.Location = new System.Drawing.Point(12, 25);
            this.SignFile.Name = "SignFile";
            this.SignFile.Size = new System.Drawing.Size(75, 23);
            this.SignFile.TabIndex = 0;
            this.SignFile.Text = "Sign File";
            this.SignFile.UseVisualStyleBackColor = true;
            this.SignFile.Click += new System.EventHandler(this.SignFile_Click);
            // 
            // SignFolder
            // 
            this.SignFolder.Location = new System.Drawing.Point(92, 25);
            this.SignFolder.Name = "SignFolder";
            this.SignFolder.Size = new System.Drawing.Size(75, 23);
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
            this.logtxt.Location = new System.Drawing.Point(12, 54);
            this.logtxt.Multiline = true;
            this.logtxt.Name = "logtxt";
            this.logtxt.ReadOnly = true;
            this.logtxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logtxt.Size = new System.Drawing.Size(595, 319);
            this.logtxt.TabIndex = 3;
            // 
            // statusBar
            // 
            this.statusBar.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusBar.Location = new System.Drawing.Point(0, 375);
            this.statusBar.Name = "statusBar";
            this.statusBar.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
            this.statusBar.Size = new System.Drawing.Size(619, 22);
            this.statusBar.TabIndex = 4;
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // strip
            // 
            this.strip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripFile});
            this.strip.Location = new System.Drawing.Point(0, 0);
            this.strip.Name = "strip";
            this.strip.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.strip.Size = new System.Drawing.Size(619, 24);
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
            this.stripFile.Size = new System.Drawing.Size(37, 22);
            this.stripFile.Text = "File";
            // 
            // newJob
            // 
            this.newJob.Name = "newJob";
            this.newJob.Size = new System.Drawing.Size(180, 22);
            this.newJob.Text = "New";
            this.newJob.Click += new System.EventHandler(this.NewJob_Click);
            // 
            // saveJob
            // 
            this.saveJob.Name = "saveJob";
            this.saveJob.Size = new System.Drawing.Size(180, 22);
            this.saveJob.Text = "Save As";
            this.saveJob.Click += new System.EventHandler(this.SaveJob_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // exit
            // 
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(180, 22);
            this.exit.Text = "Exit";
            this.exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // SignTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 397);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.strip);
            this.Controls.Add(this.logtxt);
            this.Controls.Add(this.SignFolder);
            this.Controls.Add(this.SignFile);
            this.MainMenuStrip = this.strip;
            this.MinimumSize = new System.Drawing.Size(195, 176);
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

