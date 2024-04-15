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
            this.textBoxRegex = new System.Windows.Forms.TextBox();
            this.labelRegex = new System.Windows.Forms.Label();
            this.textBoxFileURL = new System.Windows.Forms.TextBox();
            this.labelFile = new System.Windows.Forms.Label();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonBrowseFolder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxRegex
            // 
            this.textBoxRegex.Location = new System.Drawing.Point(63, 99);
            this.textBoxRegex.Name = "textBoxRegex";
            this.textBoxRegex.Size = new System.Drawing.Size(268, 20);
            this.textBoxRegex.TabIndex = 0;
            this.textBoxRegex.Text = "Введите regex";
            // 
            // labelRegex
            // 
            this.labelRegex.Location = new System.Drawing.Point(12, 103);
            this.labelRegex.Name = "labelRegex";
            this.labelRegex.Size = new System.Drawing.Size(45, 16);
            this.labelRegex.TabIndex = 1;
            this.labelRegex.Text = "Regex:";
            // 
            // textBoxFileURL
            // 
            this.textBoxFileURL.Enabled = false;
            this.textBoxFileURL.Location = new System.Drawing.Point(63, 40);
            this.textBoxFileURL.Name = "textBoxFileURL";
            this.textBoxFileURL.Size = new System.Drawing.Size(268, 20);
            this.textBoxFileURL.TabIndex = 0;
            this.textBoxFileURL.Text = "Выберите файл";
            // 
            // labelFile
            // 
            this.labelFile.Location = new System.Drawing.Point(12, 44);
            this.labelFile.Name = "labelFile";
            this.labelFile.Size = new System.Drawing.Size(45, 16);
            this.labelFile.TabIndex = 1;
            this.labelFile.Text = "File:";
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(357, 38);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(80, 23);
            this.buttonBrowse.TabIndex = 2;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(357, 97);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(80, 23);
            this.buttonSubmit.TabIndex = 2;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonBrowseFolder
            // 
            this.buttonBrowseFolder.Location = new System.Drawing.Point(459, 37);
            this.buttonBrowseFolder.Name = "buttonBrowseFolder";
            this.buttonBrowseFolder.Size = new System.Drawing.Size(113, 23);
            this.buttonBrowseFolder.TabIndex = 2;
            this.buttonBrowseFolder.Text = "Browse folder";
            this.buttonBrowseFolder.UseVisualStyleBackColor = true;
            this.buttonBrowseFolder.Click += new System.EventHandler(this.buttonBrowseFolder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 164);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.buttonBrowseFolder);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.labelFile);
            this.Controls.Add(this.labelRegex);
            this.Controls.Add(this.textBoxFileURL);
            this.Controls.Add(this.textBoxRegex);
            this.Name = "Form1";
            this.Text = "Удаление содержимого по Regex";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button buttonBrowseFolder;

        private System.Windows.Forms.Button buttonSubmit;

        private System.Windows.Forms.Label labelRegex;
        private System.Windows.Forms.TextBox textBoxFileURL;
        private System.Windows.Forms.Label labelFile;
        private System.Windows.Forms.Button buttonBrowse;

        private System.Windows.Forms.TextBox textBoxRegex;

        #endregion
    }
}