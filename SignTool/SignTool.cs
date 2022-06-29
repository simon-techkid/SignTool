using System;
using System.Windows.Forms;

namespace SignTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            statusLabel.Text = "[INFO] Ready to Sign";
        }

        int fileCount = 0;
        int exeCount = 0;
        int dllCount = 0;
        int folderJobs = 0;

        private void SignFile_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog open;

            open = new OpenFileDialog
            {
                Filter = "Executables|*.exe;*.dll",
                Multiselect = true
            };

            if (open.ShowDialog() == DialogResult.OK)
            {
                foreach (string fileName in open.FileNames)
                {
                    logtxt.Text += "[FILE SIGNER] " + fileName + "... ";
                    Application.DoEvents();
                    SignTool.SignWithCert(fileName, "http://timestamp.verisign.com/scripts/timstamp.dll");
                    fileCount += 1;
                    logtxt.Text += "OK" + Environment.NewLine;
                    statusLabel.Text = "[FILE JOB] Signed 1 File";
                }
                MessageBox.Show("FILE SIGNING COMPLETE", "JobReport", 0, MessageBoxIcon.Information);
                logtxt.Text += "[FILE JOB] Signed 1 File" + Environment.NewLine;
                logtxt.Text += Environment.NewLine;

                // Post-Job Cleanup
                statusLabel.Text = "[JobReport] Signed " + fileCount + " File(s)";
            }
        }

        private void SignFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog;

            folderDialog = new System.Windows.Forms.FolderBrowserDialog();

            if (folderDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string[] exefiles = System.IO.Directory.GetFiles(folderDialog.SelectedPath, "*.exe", System.IO.SearchOption.AllDirectories);
                string[] dllfiles = System.IO.Directory.GetFiles(folderDialog.SelectedPath, "*.dll", System.IO.SearchOption.AllDirectories);

                foreach (string fileName in exefiles)
                {
                    logtxt.Text += "[EXE SIGNER] " + fileName + "... ";
                    Application.DoEvents();
                    SignTool.SignWithCert(fileName, "http://timestamp.verisign.com/scripts/timstamp.dll");
                    fileCount += 1;
                    exeCount += 1;
                    folderJobs += 1;
                    logtxt.Text += "OK" + Environment.NewLine;
                    statusLabel.Text = "[FOLDER JOB] Signed " + folderJobs + " File(s): " + exeCount + " EXE, " + dllCount + " DLL";
                }

                foreach (string fileName in dllfiles)
                {
                    logtxt.Text += "[DLL SIGNER] " + fileName + "... ";
                    Application.DoEvents();
                    SignTool.SignWithCert(fileName, "http://timestamp.verisign.com/scripts/timstamp.dll");
                    fileCount += 1;
                    dllCount += 1;
                    folderJobs += 1;
                    logtxt.Text += "OK" + Environment.NewLine;
                    statusLabel.Text = "[FOLDER JOB] Signed " + folderJobs + " File(s): " + exeCount + " EXE, " + dllCount + " DLL";
                }

                MessageBox.Show("FOLDER SIGNING COMPLETE" + Environment.NewLine + "Folder Job: " + exeCount + " EXE, " + dllCount + " DLL", "JobReport", 0, MessageBoxIcon.Information);
                logtxt.Text += "[FOLDER JOB] Signed " + (dllCount + exeCount) + " File(s) Total: " + exeCount + " EXE, " + dllCount + " DLL" + Environment.NewLine;
                logtxt.Text += Environment.NewLine;

                // Post-Job Cleanup
                statusLabel.Text = "[JobReport] Signed " + fileCount + " File(s)";
                dllCount = 0;
                exeCount = 0;
            }
        }

        private void SaveLog_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "Text Files|*.txt"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(sfd.FileName, logtxt.Text);
            }
        }

        private void ResetJob_Click(object sender, EventArgs e)
        {
            DialogResult resetJob = MessageBox.Show("DO YOU WANT TO RESET?" + "\n" + fileCount + " File(s) Signed Total", "ResetJob", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resetJob == DialogResult.Yes)
            {
                fileCount = 0;
                exeCount = 0;
                dllCount = 0;
                folderJobs = 0;
                logtxt.Text = "";
                statusLabel.Text = "[INFO] Ready to Sign";
            }
        }
    }
}