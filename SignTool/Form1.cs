using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignTool1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog open;

            open = new OpenFileDialog();
            open.Filter = "Executables|*.exe;*.dll";
            open.Multiselect = true;

            if (open.ShowDialog() == DialogResult.OK)
            {
                foreach (string fileName in open.FileNames)
                {
                    logtxt.Text += fileName + "...";

                    Application.DoEvents();

                    SignTool.SignWithCert(fileName, "http://timestamp.verisign.com/scripts/timstamp.dll");

                    logtxt.Text += "OK" + Environment.NewLine;
                }

                System.Windows.Forms.MessageBox.Show("Done");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog folderDialog;

            folderDialog = new System.Windows.Forms.FolderBrowserDialog();

            if (folderDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string[] exefiles = System.IO.Directory.GetFiles(folderDialog.SelectedPath, "*.exe", System.IO.SearchOption.AllDirectories);
                string[] dllfiles = System.IO.Directory.GetFiles(folderDialog.SelectedPath, "*.dll", System.IO.SearchOption.AllDirectories);

                foreach (string fileName in exefiles)
                {
                    logtxt.Text += fileName + "...";
                    
                    Application.DoEvents();

                    SignTool.SignWithCert(fileName, "http://timestamp.verisign.com/scripts/timstamp.dll");

                    logtxt.Text += "OK" + Environment.NewLine;
                }

                foreach (string fileName in dllfiles)
                {
                    logtxt.Text += fileName + "...";

                    Application.DoEvents();

                    SignTool.SignWithCert(fileName, "http://timestamp.verisign.com/scripts/timstamp.dll");

                    logtxt.Text += "OK" + Environment.NewLine;
                }

                System.Windows.Forms.MessageBox.Show("Done");
            }
        }
    }
}
