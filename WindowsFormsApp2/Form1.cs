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
                this.textBoxFileURL.Text = openFileDialog.FileName;
            }
        }
        
        private void buttonSubmit_Click(object sender, EventArgs e)
        {            
            // Get the file path
            string filePath = textBoxFileURL.Text;
            
            // Check if the file exists
            if (File.Exists(filePath))
            {
                try
                {
                    // Read the file content with UTF-8 encoding
                    string fileContent;
                    using (StreamReader sr = new StreamReader(filePath, Encoding.Default))
                    {
                        fileContent = sr.ReadToEnd();
                    }
                    
                    Console.WriteLine(fileContent);
                    
                    // Get the regular expression from textBoxRegex
                    string regexPattern = textBoxRegex.Text;
                    
                    // Apply the regular expression to the file content to remove matching lines
                    string updatedContent = Regex.Replace(fileContent, regexPattern, "", RegexOptions.Multiline | RegexOptions.IgnoreCase);
                    
                    // Rewrite the file with the updated content using UTF-8 encoding
                    using (StreamWriter sw = new StreamWriter(filePath, false, Encoding.UTF8))
                    {
                        sw.Write(updatedContent);
                    }
                    
                    MessageBox.Show("Successfully removed matching lines based on the regular expression and rewritten the file.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("File does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonBrowseFolder_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}
