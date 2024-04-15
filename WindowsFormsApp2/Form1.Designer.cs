namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxFolderURL = new System.Windows.Forms.TextBox();
            this.labelFolder = new System.Windows.Forms.Label();
            this.textBoxFileURL = new System.Windows.Forms.TextBox();
            this.labelFile = new System.Windows.Forms.Label();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.buttonBrowseFolder = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxFolderURL
            // 
            this.textBoxFolderURL.Location = new System.Drawing.Point(62, 61);
            this.textBoxFolderURL.Name = "textBoxFolderURL";
            this.textBoxFolderURL.Size = new System.Drawing.Size(268, 20);
            this.textBoxFolderURL.TabIndex = 0;
            // 
            // labelFolder
            // 
            this.labelFolder.Location = new System.Drawing.Point(11, 65);
            this.labelFolder.Name = "labelFolder";
            this.labelFolder.Size = new System.Drawing.Size(45, 16);
            this.labelFolder.TabIndex = 1;
            this.labelFolder.Text = "Folder:";
            // 
            // textBoxFileURL
            // 
            this.textBoxFileURL.Location = new System.Drawing.Point(62, 14);
            this.textBoxFileURL.Name = "textBoxFileURL";
            this.textBoxFileURL.Size = new System.Drawing.Size(268, 20);
            this.textBoxFileURL.TabIndex = 0;
            // 
            // labelFile
            // 
            this.labelFile.Location = new System.Drawing.Point(11, 18);
            this.labelFile.Name = "labelFile";
            this.labelFile.Size = new System.Drawing.Size(45, 16);
            this.labelFile.TabIndex = 1;
            this.labelFile.Text = "File:";
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(356, 12);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(113, 23);
            this.buttonBrowse.TabIndex = 2;
            this.buttonBrowse.Text = "Browse file";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // buttonBrowseFolder
            // 
            this.buttonBrowseFolder.Location = new System.Drawing.Point(356, 60);
            this.buttonBrowseFolder.Name = "buttonBrowseFolder";
            this.buttonBrowseFolder.Size = new System.Drawing.Size(113, 23);
            this.buttonBrowseFolder.TabIndex = 2;
            this.buttonBrowseFolder.Text = "Browse folder";
            this.buttonBrowseFolder.UseVisualStyleBackColor = true;
            this.buttonBrowseFolder.Click += new System.EventHandler(this.buttonBrowseFolder_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(62, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(268, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(11, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Regex:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(356, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 143);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonBrowseFolder);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.labelFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelFolder);
            this.Controls.Add(this.textBoxFileURL);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxFolderURL);
            this.Name = "Form1";
            this.Text = "Удаление содержимого по Regex";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Button buttonBrowseFolder;

        private System.Windows.Forms.Label labelFolder;
        private System.Windows.Forms.TextBox textBoxFileURL;
        private System.Windows.Forms.Label labelFile;
        private System.Windows.Forms.Button buttonBrowse;

        private System.Windows.Forms.TextBox textBoxFolderURL;

        #endregion
    }
}