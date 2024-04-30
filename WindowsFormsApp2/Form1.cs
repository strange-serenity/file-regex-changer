using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonBrowseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            DialogResult result = openFileDialog.ShowDialog();
            // if a file is selected
            if (result == DialogResult.OK)
            {
                // set the path of the selected file to the text field
                textBoxFile.Text = openFileDialog.FileName;
            }

            textBoxFolder.Enabled = false;
            buttonBrowseFolder.Enabled = false;
        }

        private void buttonBrowseFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            DialogResult result = folderBrowserDialog.ShowDialog();
            // if a folder is selected
            if (result == DialogResult.OK)
            {
                // set the path of the selected folder to the text field
                textBoxFolder.Text = folderBrowserDialog.SelectedPath;
            }

            textBoxFile.Enabled = false;
            buttonBrowseFile.Enabled = false;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string regexPattern = @"<div\s+id=""blocking_overlay""\s+style=""display:\s+none;"">\s*</div>";

            if ((!string.IsNullOrEmpty(textBoxFile.Text) && !string.IsNullOrEmpty(textBoxFolder.Text))
                || (string.IsNullOrEmpty(textBoxFile.Text) && string.IsNullOrEmpty(textBoxFolder.Text)))
            {
                MessageBox.Show("Please select only one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // If file path is not empty, process single file
            if (!string.IsNullOrEmpty(textBoxFile.Text))
            {
                ProcessFile(textBoxFile.Text, regexPattern, false);
            }
            // If folder path is not empty, process all files in the folder recursively
            else
            {
                ProcessFolder(textBoxFolder.Text, regexPattern);
            }
        }

        private void ProcessFile(string filePath, string regexPattern, bool isFolder)
        {
            // Check if the file exists
            if (File.Exists(filePath))
            {
                // Check if the file extension is either ".html" or ".js"
                string extension = Path.GetExtension(filePath);
                if (extension == ".db")
                {
                   return;
                }

                try
                {
                    // Read the file content with UTF-8 encoding
                    string fileContent;
                    using (StreamReader sr = new StreamReader(filePath, Encoding.Default))
                    {
                        fileContent = sr.ReadToEnd(); // проблемное место
                    }

                    // Apply the regular expression to the file content to remove matching lines
                    string updatedContent = Regex.Replace(fileContent, regexPattern, "", RegexOptions.Multiline | RegexOptions.IgnoreCase | RegexOptions.IgnorePatternWhitespace);


                    // Rewrite the file with the updated content using UTF-8 encoding
                    using (StreamWriter sw = new StreamWriter(filePath, false, Encoding.UTF8))
                    {
                        sw.Write(updatedContent);
                    }

                    if (isFolder == false)
                    {
                        MessageBox.Show(@"Successfully removed matching lines based on the regular expression and rewritten the file.",
                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("File does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ProcessFolder(string folderPath, string regexPattern)
        {
            // Escape special characters in the regex pattern
            string escapedPattern = Regex.Escape(regexPattern);
    
            // Process all files in the folder recursively
            string[] files = Directory.GetFiles(folderPath, "*", SearchOption.AllDirectories);
            foreach (string file in files)
            {
                ProcessFile(file, escapedPattern, true);
            }

            MessageBox.Show("Successfully processed all files in the folder.", "Success", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void textBoxFile_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxFile.Text))
            {
                textBoxFolder.Text = "";
                textBoxFolder.Enabled = false;
                buttonBrowseFolder.Enabled = false;
            } else
            {
                textBoxFolder.Enabled = true;
                buttonBrowseFolder.Enabled = true;
            }

        }

        private void textBoxFolder_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxFolder.Text))
            {
                textBoxFile.Text = "";
                textBoxFile.Enabled = false;
                buttonBrowseFile.Enabled = false;
            }
            else
            {
                textBoxFile.Enabled = true;
                buttonBrowseFile.Enabled = true;
            }
        }

        private void textBoxRegex_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxRegex.Text))
            {
                removeOverlay.Enabled = true;
            }
            else
            {
                removeOverlay.Enabled = false;
            }
        }
    }
}