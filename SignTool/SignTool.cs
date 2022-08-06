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

        #region Initialization
        // prepares variables used in environment
        int totalJob = 0; //total files in job
        int totalSigned = 0; //number of files signed total
        int jobSigned = 0; //number of files in job signed

        // runs on program start
        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar.Visible = false;
            FilesListBox.Items.Clear();
            logtxt.Clear();
            statusLabel.Text = "[INFO] Welcome to SignTool version 1.3.3";
        }
        #endregion

        #region FileControlButtons

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
                    var files = GetFiles(folderDialog.SelectedPath, "*.exe;*.dll;*.sys", SearchOption.AllDirectories);
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
                Filter = "Executables|*.exe;*.dll;*.sys",
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

        #endregion

        #region SignerControlButtons
        // button for starting signing job
        private void StartJob_Click(object sender, EventArgs e)
        {
            // prepares variables and environment for signing
            totalJob = FilesListBox.CheckedItems.Count;
            progressBar.Minimum = 0;
            progressBar.Maximum = totalJob;
            progressBar.Value = 0;
            progressBar.Visible = true;
            DisableForm(true);
            logtxt.AppendText("[JOB] Initiating Job of " + totalJob + " Files" + Environment.NewLine);

            // runs signer for each file
            foreach (string file in FilesListBox.CheckedItems)
            {
                logtxt.AppendText("[" + (jobSigned + 1) + "] " + file + "... ");
                Application.DoEvents();
                SignTool.SignWithCert(file, "http://timestamp.verisign.com/scripts/timstamp.dll");
                jobSigned += 1;
                progressBar.Step = 1;
                progressBar.PerformStep();
                logtxt.Text += "OK" + Environment.NewLine;
                statusLabel.Text = "[JOB] Signed " + jobSigned + " of " + totalJob + " Files";
            }

            // runs after signing job completes
            MessageBox.Show("JOB COMPLETE" + Environment.NewLine + "Signed " + jobSigned + " of " + totalJob + " Files", "Job Report", 0, MessageBoxIcon.Information);
            logtxt.AppendText("[JOB] Completed Job of " + totalJob + " File(s): " + jobSigned + " of " + totalJob + Environment.NewLine);
            logtxt.AppendText(Environment.NewLine);

            // cleans up environment after job
            progressBar.Value = 0;
            progressBar.Visible = false;
            totalSigned += jobSigned;
            jobSigned = 0;
            statusLabel.Text = "[JOB] Signed " + totalSigned + " File(s)";
            DisableForm(false);
        }

        private void DisableForm(bool disable)
        {
            groupBoxFiles.Enabled = !disable;
            StartJob.Enabled = !disable;
            ResetJob.Enabled = !disable;
            menuList.Enabled = !disable;
        }

        // button for resetting signer output box
        private void ResetJob_Click(object sender, EventArgs e)
        {
            DialogResult resetJob = MessageBox.Show("DO YOU WANT TO RESET?" + Environment.NewLine + totalSigned + " File(s) Signed in Job" + Environment.NewLine + FilesListBox.Items.Count + " File(s) Imported to File List", "Reset Job", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
        
        // button for getting info about selected and total number of files in list
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
                File.WriteAllText(sfd.FileName, logtxt.Text);
            }
        }
        #endregion

        #region MenuSelections
        // menu selection for getting basic help info about SignTool
        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SignTool Help" + Environment.NewLine + Environment.NewLine + "Use the controls under the Files category to add entire folders or single files to the checkbox list, and uncheck or check the boxes on each file to control which are signed. To begin signing the selected files, select Start Job under the Signer category.", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // menu selection for getting contributor credits
        private void ButtonAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("About SignTool" + Environment.NewLine + Environment.NewLine + "Signer Written by eisbaer82 on XDA" + Environment.NewLine + "GUI Improved by TheBoyLeastLikelyTo on GitHub" + Environment.NewLine + "Can be used on arm32 Windows, such as RT", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // menu selection for exiting the program
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}