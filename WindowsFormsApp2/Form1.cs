using System;
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
                // Set the selected file URL to the textbox
                this.textBoxFileURL.Text = openFileDialog.FileName;
            }
        }
        
        private void buttonSubmit_Click(object sender, EventArgs e)
        {            
           
        }
    }
}