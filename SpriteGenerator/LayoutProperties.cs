﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpriteGenerator
{
    public class LayoutProperties
    {
        public string[] inputFilePaths; 
        public string outputSpriteFilePath;
        public string cssFilePath;
        public int distanceBetweenImages; 
        public int marginWidth;
        public int imagesInRow;
        public int imagesInColumn;

        public LayoutProperties()
        {
            inputFilePaths = null;
            outputSpriteFilePath = "";
            cssFilePath = "";
            distanceBetweenImages = 0;
            marginWidth = 0;
            imagesInRow = 0;
            imagesInColumn = 0;
        }
    }
}
