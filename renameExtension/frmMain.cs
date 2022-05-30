using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace renameExtension
{
    public partial class frmMain : Form
    {
        /*
            By: Manuel Dembo 
            Made in: 1day
            Date: 27/05/2022
            Description: to solve the problem that we have, when we work width HTML, CSS and PHP
                          we made the HTML and CSS together, and when we want use PHP we rename 
                          the HTML files, but it can be large process, and we need pay acttention(very)
                          to change the extension in a tags to solve this large process, i take this 
                          application "Rename Extension - we can change the extension of the files and tehe
                          extension of the a tags".
        */
        public frmMain()
        {
            InitializeComponent();
        }

        Controler controler = new Controler();

        private void lklEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.google.com/search?q=madembo18%40gmail.com&oq=madembo18%40gmail.com&aqs=chrome..69i57j69i58j69i61l2.11358j0j7&sourceid=chrome&ie=UTF-8");
        }

        private void cmdBrowse_Click_1(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folder = new FolderBrowserDialog()
            {
                Description = "Select the directory that have the files",
                SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            })
            {
                if (folder.ShowDialog() == DialogResult.OK)
                {
                    txtPath.Text = folder.SelectedPath;
                    controler.InsertFilesSelectedInList(controler.FilesInDirectory(folder.SelectedPath), lstFiles, lblCount);
                }
            }
        }

        private void cmdRename_Click(object sender, EventArgs e)
        {
            if (txtPath.Text == "") {
                MessageBox.Show("No folder selected!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtNewExtension.Text == "" || txtOldExtension.Text == "") {
                MessageBox.Show("Please fill out all fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("All files in this folder with this extension will be changed! do you want continue?", "Info", 
                                MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                return;

            txtNewExtension.Text = controler.InsertDotInExtension(txtNewExtension.Text); 
            txtOldExtension.Text = controler.InsertDotInExtension(txtOldExtension.Text);

            try {
                string[] files = new string[lstFiles.Items.Count];
                short index = 0;

                foreach (string file in lstFiles.Items) {
                    string filePath = txtPath.Text + file;

                    if(file.EndsWith(txtOldExtension.Text)){
                        files[index++] = controler.ChangeExtension(filePath, txtOldExtension.Text, txtNewExtension.Text);
                        controler.CreateFile(files[index - 1]);

                        File.Replace(filePath, files[index - 1], files[index - 1] + ".txt");
                        File.Delete(files[index - 1] + ".txt");
                    }
                }

                MessageBox.Show("Changes done with success!");

            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdBrowseFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog file = new OpenFileDialog()
            {
                Title = "Selecte the file that will be change",
                ValidateNames = true,
                Multiselect = true,
                Filter = "PHP documents (*.php) |*.php| HTML documents (*.html) |*.html| CSS documents (*.css) |*.css" +
                         "| JS documents (*.js) |*.js| TXT documents (*.txt) |*.txt| All documents (*.*) | *.*"
            })
            {
                if (file.ShowDialog() == DialogResult.OK)
                {
                    controler.InsertFilesSelectedInList(file.FileNames, lstSelectedFiles, lblCountFile);
                    txtMainPath.Text = file.FileName.Replace(@"\"+file.SafeFileName, "");
                }
            }
        }

        private void cmdRenameFile_Click(object sender, EventArgs e)
        {
            if (lstSelectedFiles.Items.Count < 1) {
                MessageBox.Show("No file selected!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtNewExtensionFile.Text == "" || txtOldExtensionFile.Text == "")
            {
                MessageBox.Show("Please fill out all fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("All selected files will be changed! do you want continue?", "Info",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                return;

            txtNewExtensionFile.Text = controler.InsertDotInExtension(txtNewExtensionFile.Text);
            txtOldExtensionFile.Text = controler.InsertDotInExtension(txtOldExtensionFile.Text);

            try
            {
                string[] files = new string[lstSelectedFiles.Items.Count];

                foreach (string file in lstSelectedFiles.Items) {
                    controler.ChangeContent(txtMainPath.Text + file, txtOldExtensionFile.Text, txtNewExtensionFile.Text, rbAll.Checked);
                }

                MessageBox.Show("Changes done with success!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By: Manuel Dembo\n Made in: 1day\n Date: 27 / 05 / 2022\n Description: to solve the problem that we have, when we work width HTML, CSS and PHP we made the HTML and CSS together, and when we want use PHP we rename the HTML files, but it can be large process, and we need pay acttention(very) to change the extension in a tags to solve this large process, i take this application \"Rename Extension - we can change the extension of the files and tehe extension of the a tags\".", "Help");
        }
    }
}
