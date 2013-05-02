using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SpriteGenerator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            LayoutProperties layoutProp = new LayoutProperties();
            if (args.Contains("-images"))
            {
                string spritePath = args.ElementAt(Array.IndexOf(args, "-images") + 1);
                layoutProp.outputSpriteFilePath = spritePath + @"\sprite.png";
                string[] filters = { ".png", ".jpg", ".jpeg", ".gif" };
                layoutProp.inputFilePaths = (from filter in filters
                                             from file in Directory.GetFiles(spritePath)
                                             where file.EndsWith(filter)
                                             select file).ToArray();
            }

            if (args.Contains("-css"))
            {
                layoutProp.cssFilePath = args.ElementAt(Array.IndexOf(args, "-css") + 1);
            }

            if (args.Contains("-gui"))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new SpritesForm(layoutProp));
            }
            else
            {
                Sprite sprite = new Sprite(layoutProp);
                sprite.Create();
            }
        }
    }
}
