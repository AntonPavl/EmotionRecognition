using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageRecognition
{
    public static class Config
    {
        public const int WindowWidth = 24;
        public const int WindowHeight = 24;

        public const int WindowStartX = 0;
        public const int WindowStartY = 0;
        public const float WindowScale = 1.25f;

        // Set the shift between each window
        public const int WindowDX = 1;
        public const int WindowDY = 1;

        public const byte R = 255;
        public const byte G = 255;
        public const byte B = 255;
    }
}
