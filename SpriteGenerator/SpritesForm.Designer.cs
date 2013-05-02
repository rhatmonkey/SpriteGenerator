namespace SpriteGenerator
{
    partial class SpritesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpritesForm));
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxInputDirectoryPath = new System.Windows.Forms.TextBox();
            this.textBoxCssFilePath = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialogOutputImage = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialogOutputCss = new System.Windows.Forms.SaveFileDialog();
            this.buttonBrowseFolder = new System.Windows.Forms.Button();
            this.buttonSelectOutputCSSFilePath = new System.Windows.Forms.Button();
            this.groupBoxPaths = new System.Windows.Forms.GroupBox();
            this.openFileDialogSelectCss = new System.Windows.Forms.OpenFileDialog();
            this.groupBoxPaths.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(285, 96);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(75, 23);
            this.buttonGenerate.TabIndex = 3;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Images directory path:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "CSS file path:";
            // 
            // textBoxInputDirectoryPath
            // 
            this.textBoxInputDirectoryPath.Location = new System.Drawing.Point(132, 19);
            this.textBoxInputDirectoryPath.Name = "textBoxInputDirectoryPath";
            this.textBoxInputDirectoryPath.ReadOnly = true;
            this.textBoxInputDirectoryPath.Size = new System.Drawing.Size(127, 20);
            this.textBoxInputDirectoryPath.TabIndex = 0;
            // 
            // textBoxCssFilePath
            // 
            this.textBoxCssFilePath.Location = new System.Drawing.Point(132, 45);
            this.textBoxCssFilePath.Name = "textBoxCssFilePath";
            this.textBoxCssFilePath.ReadOnly = true;
            this.textBoxCssFilePath.Size = new System.Drawing.Size(127, 20);
            this.textBoxCssFilePath.TabIndex = 2;
            // 
            // saveFileDialogOutputImage
            // 
            this.saveFileDialogOutputImage.Filter = "PNG Image|*.png";
            // 
            // saveFileDialogOutputCss
            // 
            this.saveFileDialogOutputCss.Filter = "CSS file|*.css";
            // 
            // buttonBrowseFolder
            // 
            this.buttonBrowseFolder.Location = new System.Drawing.Point(276, 17);
            this.buttonBrowseFolder.Name = "buttonBrowseFolder";
            this.buttonBrowseFolder.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseFolder.TabIndex = 8;
            this.buttonBrowseFolder.Text = "Browse";
            this.buttonBrowseFolder.UseVisualStyleBackColor = true;
            this.buttonBrowseFolder.Click += new System.EventHandler(this.buttonBrowseFolder_Click);
            // 
            // buttonSelectOutputCSSFilePath
            // 
            this.buttonSelectOutputCSSFilePath.Location = new System.Drawing.Point(276, 43);
            this.buttonSelectOutputCSSFilePath.Name = "buttonSelectOutputCSSFilePath";
            this.buttonSelectOutputCSSFilePath.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectOutputCSSFilePath.TabIndex = 10;
            this.buttonSelectOutputCSSFilePath.Text = "Browse";
            this.buttonSelectOutputCSSFilePath.UseVisualStyleBackColor = true;
            this.buttonSelectOutputCSSFilePath.Click += new System.EventHandler(this.buttonSelectOutputCssFilePath_Click);
            // 
            // groupBoxPaths
            // 
            this.groupBoxPaths.Controls.Add(this.label1);
            this.groupBoxPaths.Controls.Add(this.textBoxInputDirectoryPath);
            this.groupBoxPaths.Controls.Add(this.buttonSelectOutputCSSFilePath);
            this.groupBoxPaths.Controls.Add(this.buttonBrowseFolder);
            this.groupBoxPaths.Controls.Add(this.textBoxCssFilePath);
            this.groupBoxPaths.Controls.Add(this.label3);
            this.groupBoxPaths.Location = new System.Drawing.Point(9, 12);
            this.groupBoxPaths.Name = "groupBoxPaths";
            this.groupBoxPaths.Size = new System.Drawing.Size(357, 78);
            this.groupBoxPaths.TabIndex = 11;
            this.groupBoxPaths.TabStop = false;
            this.groupBoxPaths.Text = "Paths";
            // 
            // openFileDialogSelectCss
            // 
            this.openFileDialogSelectCss.FileName = "openFileDialogSelectCss";
            // 
            // SpritesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 139);
            this.Controls.Add(this.groupBoxPaths);
            this.Controls.Add(this.buttonGenerate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SpritesForm";
            this.Text = "Sprite Generator";
            this.groupBoxPaths.ResumeLayout(false);
            this.groupBoxPaths.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxInputDirectoryPath;
        private System.Windows.Forms.TextBox textBoxCssFilePath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialogOutputImage;
        private System.Windows.Forms.SaveFileDialog saveFileDialogOutputCss;
        private System.Windows.Forms.Button buttonBrowseFolder;
        private System.Windows.Forms.Button buttonSelectOutputCSSFilePath;
        private System.Windows.Forms.GroupBox groupBoxPaths;
        private System.Windows.Forms.OpenFileDialog openFileDialogSelectCss;
    }
}

