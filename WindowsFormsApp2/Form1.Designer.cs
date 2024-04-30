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
            this.textBoxFolder = new System.Windows.Forms.TextBox();
            this.labelFolder = new System.Windows.Forms.Label();
            this.textBoxFile = new System.Windows.Forms.TextBox();
            this.labelFile = new System.Windows.Forms.Label();
            this.buttonBrowseFile = new System.Windows.Forms.Button();
            this.buttonBrowseFolder = new System.Windows.Forms.Button();
            this.removeOverlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxFolder
            // 
            this.textBoxFolder.Location = new System.Drawing.Point(62, 61);
            this.textBoxFolder.Name = "textBoxFolder";
            this.textBoxFolder.Size = new System.Drawing.Size(268, 20);
            this.textBoxFolder.TabIndex = 0;
            this.textBoxFolder.TextChanged += new System.EventHandler(this.textBoxFolder_TextChanged);
            // 
            // labelFolder
            // 
            this.labelFolder.Location = new System.Drawing.Point(11, 65);
            this.labelFolder.Name = "labelFolder";
            this.labelFolder.Size = new System.Drawing.Size(45, 16);
            this.labelFolder.TabIndex = 1;
            this.labelFolder.Text = "Folder:";
            // 
            // textBoxFile
            // 
            this.textBoxFile.Location = new System.Drawing.Point(62, 14);
            this.textBoxFile.Name = "textBoxFile";
            this.textBoxFile.Size = new System.Drawing.Size(268, 20);
            this.textBoxFile.TabIndex = 0;
            this.textBoxFile.TextChanged += new System.EventHandler(this.textBoxFile_TextChanged);
            // 
            // labelFile
            // 
            this.labelFile.Location = new System.Drawing.Point(11, 18);
            this.labelFile.Name = "labelFile";
            this.labelFile.Size = new System.Drawing.Size(45, 16);
            this.labelFile.TabIndex = 1;
            this.labelFile.Text = "File:";
            // 
            // buttonBrowseFile
            // 
            this.buttonBrowseFile.Location = new System.Drawing.Point(356, 12);
            this.buttonBrowseFile.Name = "buttonBrowseFile";
            this.buttonBrowseFile.Size = new System.Drawing.Size(113, 23);
            this.buttonBrowseFile.TabIndex = 2;
            this.buttonBrowseFile.Text = "Browse file";
            this.buttonBrowseFile.UseVisualStyleBackColor = true;
            this.buttonBrowseFile.Click += new System.EventHandler(this.buttonBrowseFile_Click);
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
            // removeOverlay
            // 
            this.removeOverlay.Enabled = false;
            this.removeOverlay.Location = new System.Drawing.Point(12, 108);
            this.removeOverlay.Name = "removeOverlay";
            this.removeOverlay.Size = new System.Drawing.Size(113, 23);
            this.removeOverlay.TabIndex = 2;
            this.removeOverlay.Text = "Remove overlay div";
            this.removeOverlay.UseVisualStyleBackColor = true;
            this.removeOverlay.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 143);
            this.Controls.Add(this.removeOverlay);
            this.Controls.Add(this.buttonBrowseFolder);
            this.Controls.Add(this.buttonBrowseFile);
            this.Controls.Add(this.labelFile);
            this.Controls.Add(this.labelFolder);
            this.Controls.Add(this.textBoxFile);
            this.Controls.Add(this.textBoxFolder);
            this.Name = "Form1";
            this.Text = "Удаление содержимого по Regex";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button removeOverlay;

        private System.Windows.Forms.Button buttonBrowseFolder;

        private System.Windows.Forms.Label labelFolder;
        private System.Windows.Forms.TextBox textBoxFile;
        private System.Windows.Forms.Label labelFile;
        private System.Windows.Forms.Button buttonBrowseFile;

        private System.Windows.Forms.TextBox textBoxFolder;

        #endregion
    }
}