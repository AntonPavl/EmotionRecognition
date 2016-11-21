using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageRecognition
{
    public static class Config
    {
        public static int WindowWidth = 300;
        public static int WindowHeight = 200;

        public static int WindowStartX = 0;
        public static int WindowStartY = 0;
        public static float WindowScale = 1.5f;

        // Set the shift between each window
        public static int WindowDX = 10;
        public static int WindowDY = 10;

        public static byte R = 255;
        public static byte G = 255;
        public static byte B = 255;
    }
}
