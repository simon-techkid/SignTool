using System;
using System.IO;
using System.Linq;
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

        int totalJob = 0; //total files in job
        int totalSigned = 0; //number of files signed total
        int jobSigned = 0; //number of files in job signed

        private void ClearFiles_Click(object sender, EventArgs e)
        {
            FilesListBox.Items.Clear();
        }

        private void AddFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog;
            folderDialog = new System.Windows.Forms.FolderBrowserDialog();

            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var files = GetFiles(folderDialog.SelectedPath, "*.exe;*.dll", SearchOption.AllDirectories);
                    foreach (string file in files)
                    {
                        totalJob += 1;
                        FilesListBox.Items.Add(file);
                    }
                }
                catch { }
            }
        }

        private void AddFile_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog openFile;

            openFile = new OpenFileDialog
            {
                Filter = "Executables|*.exe;*.dll",
                Multiselect = true
            };
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                foreach (string fileName in openFile.FileNames)
                {
                    totalJob += 1;
                    FilesListBox.Items.Add(fileName, true);
                }
            }
        }

        private static string[] GetFiles(string sourceFolder, string filters, SearchOption searchOption)
        {
            return filters.Split(';').SelectMany(filter => Directory.GetFiles(sourceFolder, filter, searchOption)).ToArray();
        }

        private void SelectAllFiles_Click(object sender, EventArgs e)
        {
            bool AllFilesSelected = false;
            if (SelectAllFiles.Text == "Select All")
            {
                AllFilesSelected = true;
                SelectAllFiles.Text = "Deselect All";
            }
            else if (SelectAllFiles.Text == "Deselect All")
            {
                AllFilesSelected = false;
                SelectAllFiles.Text = "Select All";
            }
            int count = FilesListBox.Items.Count;
            for (int i = 0; i < count; i++)
                FilesListBox.SetItemChecked(i, AllFilesSelected);
        }

        private void SignFolder_Click(object sender, EventArgs e)
        {
            progressBar.Minimum = 0;
            progressBar.Maximum = totalJob;
            progressBar.Value = 0;
            groupBoxFiles.Enabled = false;
            groupBoxSigner.Enabled = false;
            logtxt.Text += "[JOB] Initiating Job of " + totalJob + " Files" + Environment.NewLine;

            foreach (string file in FilesListBox.CheckedItems)
            {
                logtxt.Text += "[SIGNER] " + file + "... ";
                Application.DoEvents();
                SignTool.SignWithCert(file, "http://timestamp.verisign.com/scripts/timstamp.dll");
                jobSigned += 1;
                progressBar.Step = 1;
                progressBar.PerformStep();
                logtxt.Text += "OK" + Environment.NewLine;
                statusLabel.Text = "[JOB] Signed " + jobSigned + " of " + totalJob + " Files";
            }

            MessageBox.Show("JOB COMPLETE" + Environment.NewLine + "Signed " + jobSigned + " of " + totalJob + " Files", "JobReport", 0, MessageBoxIcon.Information);
            logtxt.Text += "[JOB] Completed Job of " + totalJob + " File(s): " + jobSigned + " of " + totalJob + Environment.NewLine;
            logtxt.Text += Environment.NewLine;

            // Post-Job Cleanup
            progressBar.Value = 0;
            totalSigned += jobSigned;
            jobSigned = 0;
            statusLabel.Text = "[JobReport] Signed " + totalSigned + " File(s)";
            groupBoxFiles.Enabled = true;
            groupBoxSigner.Enabled = true;
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
            DialogResult resetJob = MessageBox.Show("DO YOU WANT TO RESET?" + "\n" + totalSigned + " File(s) Signed Total", "ResetJob", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resetJob == DialogResult.Yes)
            {
                totalSigned = 0;
                totalJob = 0;
                jobSigned = 0;
                progressBar.Value = 0;
                logtxt.Clear();
                statusLabel.Text = "[INFO] Ready to Sign";
            }
        }
    }
}