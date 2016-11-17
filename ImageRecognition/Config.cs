using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageRecognition
{
    public static class Config
    {
        public const int WindowWidth = 36;
        public const int WindowHeight = 36;

        public const float WindowScale = 1.25f;

        // Set the shift between each window
        public const int WindowDX = 1;
        public const int WindowDY = 1;

        // Set the shift between each feature
        public const int FeatureDX = 1;
        public const int FeatureDY = 1;

        // Set the deep of the learning tests
        public const int LearnPass = 400;

        // Set the maximum memory usage of the trainner
        // in KiB
        public const int MinFreeMemory = 350 * 1024;

        public const byte R = 255;
        public const byte G = 255;
        public const byte B = 255;
    }
}
