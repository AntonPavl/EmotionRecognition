using MathMath;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageRecognition.Filters.Implementations
{
    public class LowFreqFilter : IFilter
    {
        private int[,] _matrix;

        public LowFreqFilter(int[,] matrix)
        {
            _matrix = matrix;
        }

        public Image Apply(Image img)
        {
            var image = new Image(img);
            var m = new Matrix(_matrix);
            for(int i = 1; i < image.Height - 1; i++)
            {
                for(int j = 1; j < image.Width - 1; j++)
                {
                    var pixel = image[i, j];
                    pixel.Blue  = Calculate(i, j, m, (x, y) => image[x, y].Blue);
                    pixel.Green = Calculate(i, j, m, (x, y) => image[x, y].Green);
                    pixel.Red   = Calculate(i, j, m, (x, y) => image[x, y].Red);
                    image[i, j] = pixel;
                }
            }

            return image;
        }

        private byte Calculate(int x, int y, Matrix m, Func<int, int, byte> get)
        {
            return (byte)(m.Result(x, y, get) / m.Size);
        }
    }
}
