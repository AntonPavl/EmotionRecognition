using MathMath;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ImageRecognition.Filters.Implementations
{
    public class SobelFilter : IFilter
    {
        private int[,] _matrixX;
        private int[,] _matrixY;

        double blueX = 0.0;
        double greenX = 0.0;
        double redX = 0.0;

        double blueY = 0.0;
        double greenY = 0.0;
        double redY = 0.0;

        double blueTotal = 0.0;
        double greenTotal = 0.0;
        double redTotal = 0.0;

        public SobelFilter()
        {
            _matrixX = Matrixs.Sobel3x3Horizontal;
            _matrixY = Matrixs.Sobel3x3Vertical;
        }

        public Image Apply(Image img)
        {
            return img;
        }

        private byte Calculate(int x, int y, Matrix m, Func<int, int, byte> get)
        {
            return (byte)m.Result(x, y, get);
        }

    }
}
