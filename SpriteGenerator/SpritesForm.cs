using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace SpriteGenerator
{
    public partial class SpritesForm : Form
    {
        private LayoutProperties layoutProp = new LayoutProperties();

        public SpritesForm(LayoutProperties layout)
        {
            InitializeComponent();
            layoutProp = layout;
            textBoxInputDirectoryPath.Text = layoutProp.outputSpriteFilePath;
            textBoxCssFilePath.Text = layoutProp.cssFilePath;
        }

        //Generate button click event. Start generating output image and CSS file.
        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            layoutProp.cssFilePath = textBoxCssFilePath.Text;
            layoutProp.outputSpriteFilePath = textBoxInputDirectoryPath.Text;
            Sprite sprite = new Sprite(layoutProp);
            sprite.Create();
            this.Close();
        }

        //Browse input images folder.
        private void buttonBrowseFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string[] filters = { ".png", ".jpg", ".jpeg", ".gif" };
                layoutProp.inputFilePaths = (from filter in filters
                                  from file in Directory.GetFiles(folderBrowserDialog.SelectedPath)
                                  where file.EndsWith(filter)
                                  select file).ToArray();
                //If there is no file with the enabled formats in the choosen directory.
                if (layoutProp.inputFilePaths.Length == 0)
                    MessageBox.Show("This directory does not contain image files.");

                //If there are files with the enabled formats in the choosen directory.
                else
                {
                    this.textBoxInputDirectoryPath.Text = folderBrowserDialog.SelectedPath + @"\sprite.png";
                    
                    buttonGenerate.Enabled = true;
                    
                    int width = Image.FromFile(layoutProp.inputFilePaths[0]).Width;
                    int height = Image.FromFile(layoutProp.inputFilePaths[0]).Height;
                }
            }
        }

        //Select output CSS file path.
        private void buttonSelectOutputCssFilePath_Click(object sender, EventArgs e)
        {
            if (openFileDialogSelectCss.ShowDialog() == DialogResult.OK)
            {
                this.textBoxCssFilePath.Text = openFileDialogSelectCss.FileName; 
                buttonGenerate.Enabled = true;
            }
        }

    }
}
