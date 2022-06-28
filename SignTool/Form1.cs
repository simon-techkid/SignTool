using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                    logtxt.Text += "[SIGNER] " + fileName + "... ";
                    Application.DoEvents();
                    SignTool.SignWithCert(fileName, "http://timestamp.verisign.com/scripts/timstamp.dll");
                    fileCount += 1;
                    logtxt.Text += "OK" + Environment.NewLine;
                    statusLabel.Text = "[SIGNER] Signed " + fileCount + " File(s)";
                }
                System.Windows.Forms.MessageBox.Show("FILE SIGNING COMPLETE" + "\n" + fileCount + " File(s) Signed in Job", "JobReport", 0, MessageBoxIcon.Information);
                statusLabel.Text = "[INFO] Ready to Sign";
            }
            else
            {
                statusLabel.Text = "[ERROR] Opening File Selection Dialog Failed";
            }
        }

        private void SignFolder_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog folderDialog;

            folderDialog = new System.Windows.Forms.FolderBrowserDialog();

            if (folderDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string[] exefiles = System.IO.Directory.GetFiles(folderDialog.SelectedPath, "*.exe", System.IO.SearchOption.AllDirectories);
                string[] dllfiles = System.IO.Directory.GetFiles(folderDialog.SelectedPath, "*.dll", System.IO.SearchOption.AllDirectories);

                foreach (string fileName in exefiles)
                {
                    logtxt.Text += "[SIGNER] " + fileName + "... ";
                    Application.DoEvents();
                    SignTool.SignWithCert(fileName, "http://timestamp.verisign.com/scripts/timstamp.dll");
                    fileCount += 1;
                    exeCount += 1;
                    logtxt.Text += "OK" + Environment.NewLine;
                    statusLabel.Text = "[SIGNER] Signed " + fileCount + " File(s): " + exeCount + " EXE, " + dllCount + " DLL";
                }

                foreach (string fileName in dllfiles)
                {
                    logtxt.Text += "[SIGNER] " + fileName + "... ";
                    Application.DoEvents();
                    SignTool.SignWithCert(fileName, "http://timestamp.verisign.com/scripts/timstamp.dll");
                    fileCount += 1;
                    dllCount += 1;
                    logtxt.Text += "OK" + Environment.NewLine;
                    statusLabel.Text = "[SIGNER] Signed " + fileCount + " File(s): " + exeCount + " EXE, " + dllCount + " DLL";
                }

                System.Windows.Forms.MessageBox.Show("FOLDER SIGNING COMPLETE" + "\n" + fileCount + " File(s) Signed in Job:" + "\n" + exeCount + " EXE, " + dllCount + " DLL", "JobReport", 0, MessageBoxIcon.Information);
                statusLabel.Text = "[INFO] Ready to Sign";
            }
        }

        private void SaveLog_Click(object sender, EventArgs e)
        {

        }

        private void Reset_Click(object sender, EventArgs e)
        {

        }

        private void NewJob_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("DO YOU WANT TO RESET?" + "\n" + fileCount + " File(s) Signed: " + exeCount + " EXE, " + dllCount + " DLL", "ResetJob", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                fileCount = 0;
                exeCount = 0;
                dllCount = 0;
                logtxt.Text = "";
                statusLabel.Text = "[INFO] Ready to Sign, ResetJob";
            }
        }

        private void SaveJob_Click(object sender, EventArgs e)
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

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}