using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using SpriteGenerator.Utility;
using System.Text.RegularExpressions;

namespace SpriteGenerator
{
    class Sprite
    {
        private Dictionary<int, Image> images;
        private Dictionary<int, string> cssClassNames;
        private LayoutProperties layoutProp;

        public Sprite(LayoutProperties _layoutProp)
        {
            images = new Dictionary<int, Image>();
            cssClassNames = new Dictionary<int, string>();
            layoutProp = _layoutProp;
        }

        public void Create()
        {
            GetData(out images, out cssClassNames);

            string cssFile = File.ReadAllText(layoutProp.cssFilePath);
            
            Image resultSprite = null;

            resultSprite = generateAutomaticLayout(ref cssFile);

            File.WriteAllText(layoutProp.cssFilePath, cssFile);

            if (File.Exists(layoutProp.outputSpriteFilePath))
                File.Delete(layoutProp.outputSpriteFilePath);

            FileStream outputSpriteFile = new FileStream(layoutProp.outputSpriteFilePath, FileMode.Create, FileAccess.Write);
            resultSprite.Save(outputSpriteFile, ImageFormat.Png);
            outputSpriteFile.Close();
        }

        /// <summary>
        /// Creates dictionary of images from the given paths and dictionary of CSS classnames from the image filenames.
        /// </summary> 
        /// <param name="inputFilePaths">Array of input file paths.</param>
        /// <param name="images">Dictionary of images to be inserted into the output sprite.</param>
        /// <param name="cssClassNames">Dictionary of CSS classnames.</param>
        private void GetData(out Dictionary<int, Image> images, out Dictionary<int, string> cssClassNames)
        {
            images = new Dictionary<int, Image>();
            cssClassNames = new Dictionary<int, string>();

            for (int i = 0; i < layoutProp.inputFilePaths.Length; i++)
            {
                Image img = Image.FromFile(layoutProp.inputFilePaths[i]);
                images.Add(i, img);
                string[] splittedFilePath = layoutProp.inputFilePaths[i].Split('\\');
                cssClassNames.Add(i, splittedFilePath[splittedFilePath.Length - 1]);
            }
        }

        private List<Module> CreateModules()
        {
            List<Module> modules = new List<Module>();
            foreach (int i in images.Keys)
                modules.Add(new Module(i, images[i], layoutProp.distanceBetweenImages));
            return modules;
        }

        //CSS line
        private string CssLine(string cssClassName, Rectangle rectangle)
        {
            return string.Format("background: url('{0}') {1}px {2}px;", relativeSpriteImagePath(layoutProp.outputSpriteFilePath, layoutProp.cssFilePath), (-1 * rectangle.X).ToString(), (-1 * rectangle.Y).ToString());
        }

        //Relative sprite image file path
        private string relativeSpriteImagePath(string outputSpriteFilePath, string outputCssFilePath)
        {
            string[] splittedOutputCssFilePath = outputCssFilePath.Split('\\');
            string[] splittedOutputSpriteFilePath = outputSpriteFilePath.Split('\\');

            int breakAt = 0;
            for (int i = 0; i < splittedOutputCssFilePath.Length; i++)
                if (i < splittedOutputSpriteFilePath.Length && splittedOutputCssFilePath[i] != splittedOutputSpriteFilePath[i])
                {
                    breakAt = i;
                    break;
                }

            string relativePath = "";
            for (int i = 0; i < splittedOutputCssFilePath.Length - breakAt - 1; i++)
                relativePath += "../";
            relativePath += String.Join("/", splittedOutputSpriteFilePath, breakAt, splittedOutputSpriteFilePath.Length - breakAt);

            return relativePath;
        }

        //Automatic layout
        private Image generateAutomaticLayout(ref string cssFile)
        {
            var sortedByArea = from m in CreateModules()
                               orderby m.Width * m.Height descending
                               select m;
            List<Module> moduleList = sortedByArea.ToList<Module>();
            Placement placement = Algorithm.Greedy(moduleList);

            //Creating an empty result image.
            Image resultSprite = new Bitmap(placement.Width - layoutProp.distanceBetweenImages + 2 * layoutProp.marginWidth,
                placement.Height - layoutProp.distanceBetweenImages + 2 * layoutProp.marginWidth);
            Graphics graphics = Graphics.FromImage(resultSprite);
            
            //Drawing images into the result image in the original order and writing CSS lines.
            foreach (Module m in placement.Modules)
            {
                m.Draw(graphics, layoutProp.marginWidth);
                Rectangle rectangle = new Rectangle(m.X + layoutProp.marginWidth, m.Y + layoutProp.marginWidth,
                    m.Width - layoutProp.distanceBetweenImages, m.Height - layoutProp.distanceBetweenImages);
                cssFile = Regex.Replace(cssFile, @"background?.*:\W.*("+cssClassNames[m.Name]+").*", CssLine(cssClassNames[m.Name], rectangle));
            }

            return resultSprite;
        }
    }
}
