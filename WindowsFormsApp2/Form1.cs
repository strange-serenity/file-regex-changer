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

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            DialogResult result = openFileDialog.ShowDialog();
            // if a file is selected
            if (result == DialogResult.OK)
            {
                // set the path of the selected file to the text field
                textBoxFileURL.Text = openFileDialog.FileName;
            }

            textBoxFolderURL.Enabled = false;
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
                textBoxFolderURL.Text = folderBrowserDialog.SelectedPath;
            }

            textBoxFileURL.Enabled = false;
            buttonBrowse.Enabled = false;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string regexPattern = textBox1.Text;

            if ((!string.IsNullOrEmpty(textBoxFileURL.Text) && !string.IsNullOrEmpty(textBoxFolderURL.Text))
                || (string.IsNullOrEmpty(textBoxFileURL.Text) && string.IsNullOrEmpty(textBoxFolderURL.Text)))
            {
                MessageBox.Show("Please select only one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // If file path is not empty, process single file
            if (!string.IsNullOrEmpty(textBoxFileURL.Text))
            {
                ProcessFile(textBoxFileURL.Text, regexPattern);
            }
            // If folder path is not empty, process all files in the folder recursively
            else
            {
                ProcessFolder(textBoxFolderURL.Text, regexPattern);
            }
        }

        private void ProcessFile(string filePath, string regexPattern)
        {
            // Check if the file exists
            if (File.Exists(filePath))
            {
                try
                {
                    // Read the file content with UTF-8 encoding
                    string fileContent;
                    using (StreamReader sr = new StreamReader(filePath, Encoding.Default))
                    {
                        fileContent = sr.ReadToEnd(); // проблемное место
                    }

                    // Apply the regular expression to the file content to remove matching lines
                    string updatedContent = Regex.Replace(fileContent, regexPattern, "",
                        RegexOptions.Multiline | RegexOptions.IgnoreCase);

                    // Rewrite the file with the updated content using UTF-8 encoding
                    using (StreamWriter sw = new StreamWriter(filePath, false, Encoding.UTF8))
                    {
                        sw.Write(updatedContent);
                    }

                    MessageBox.Show(
                        "Successfully removed matching lines based on the regular expression and rewritten the file.",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                Console.WriteLine(file + ", " + escapedPattern);
                ProcessFile(file, escapedPattern);
            }

            MessageBox.Show("Successfully processed all files in the folder.", "Success", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

    }
}