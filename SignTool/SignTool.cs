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
        }

        int totalJob = 0; //total files in job
        int totalSigned = 0; //number of files signed total
        int jobSigned = 0; //number of files in job signed

        // runs on program start
        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar.Visible = false;
            FilesListBox.Items.Clear();
            logtxt.Clear();
            statusLabel.Text = "[INFO] Welcome to SignTool version 1.3.1";
        }

        // button for clearing contents of files list
        private void ClearFiles_Click(object sender, EventArgs e)
        {
            FilesListBox.Items.Clear();
            statusLabel.Text = "[INFO] Ready to Sign, Add a Folder or File to List";
        }

        // button for selecting/deselecting all files
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

        // import folders and subfolders
        private void AddFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog;
            folderDialog = new System.Windows.Forms.FolderBrowserDialog();

            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var files = GetFiles(folderDialog.SelectedPath, "*.exe;*.dll", SearchOption.AllDirectories);
                    foreach (string fileName in files)
                    {
                        FilesListBox.Items.Add(fileName, true);
                    }
                    statusLabel.Text = "[INFO] " + FilesListBox.Items.Count + " Files Imported to File List";
                }
                catch { }
            }
        }

        // import individual files
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
                    FilesListBox.Items.Add(fileName, true);
                }
                statusLabel.Text = "[INFO] " + FilesListBox.Items.Count + " Files Imported to File List";
            }
        }

        // folder import dll and exe files to GetFiles
        private static string[] GetFiles(string sourceFolder, string filters, SearchOption searchOption)
        {
            return filters.Split(';').SelectMany(filter => Directory.GetFiles(sourceFolder, filter, searchOption)).ToArray();
        }

        // button for starting signing job
        private void SignFolder_Click(object sender, EventArgs e)
        {
            totalJob = FilesListBox.CheckedItems.Count;
            progressBar.Minimum = 0;
            progressBar.Maximum = totalJob;
            progressBar.Value = 0;
            progressBar.Visible = true;
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

            MessageBox.Show("JOB COMPLETE" + Environment.NewLine + "Signed " + jobSigned + " of " + totalJob + " Files", "Job", 0, MessageBoxIcon.Information);
            logtxt.Text += "[JOB] Completed Job of " + totalJob + " File(s): " + jobSigned + " of " + totalJob + Environment.NewLine;
            logtxt.Text += Environment.NewLine;

            // Post-Job Cleanup
            progressBar.Value = 0;
            progressBar.Visible = false;
            totalSigned += jobSigned;
            jobSigned = 0;
            statusLabel.Text = "[JOB] Signed " + totalSigned + " File(s)";
            groupBoxFiles.Enabled = true;
            groupBoxSigner.Enabled = true;
        }

        // button for resetting signer output box
        private void ResetJob_Click(object sender, EventArgs e)
        {
            DialogResult resetJob = MessageBox.Show("DO YOU WANT TO RESET?" + Environment.NewLine + totalSigned + " File(s) Signed Total" + Environment.NewLine + FilesListBox.Items.Count + " File(s) Imported to File List", "Reset Job", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resetJob == DialogResult.Yes)
            {
                totalSigned = 0;
                totalJob = 0;
                jobSigned = 0;
                progressBar.Value = 0;
                logtxt.Clear();
                FilesListBox.Items.Clear();
                statusLabel.Text = "[INFO] Ready to Sign, Add a Folder or File to List";
            }
        }
        private void JobFilesInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(FilesListBox.CheckedItems.Count + " of " + FilesListBox.Items.Count + " Files Selected", "Job Files", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // button for saving signer output to plain text
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

        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SignTool Help" + Environment.NewLine + Environment.NewLine + "Use the controls under the Files category to add entire folders or single files to the checkbox list, and uncheck or check the boxes on each file to control which are signed. To begin signing the selected files, select Start Job under the Signer category.", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ButtonAbout_Click(object sender, EventArgs e)
        {
            
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}