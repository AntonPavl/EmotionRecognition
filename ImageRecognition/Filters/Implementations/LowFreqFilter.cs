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

            for(int i = 1; i < image.Height - 1; i++)
            {
                for(int j = 1; j < image.Width - 1; j++)
                {
                    var pixel = image[i, j];
                    pixel.Blue  = Calculate(i, j, _matrix, (x, y) => image[x, y].Blue);
                    pixel.Green = Calculate(i, j, _matrix, (x, y) => image[x, y].Green);
                    pixel.Red   = Calculate(i, j, _matrix, (x, y) => image[x, y].Red);
                    image[i, j] = pixel;
                }
            }

            return image;
        }

        private byte Calculate(int x, int y, int[,] matrix, Func<int, int, byte> get)
        {
            double sum = 0.0;

            sum += get(x, y)         * matrix[1, 1];
            sum += get(x - 1, y)     * matrix[0, 1];
            sum += get(x - 1, y - 1) * matrix[0, 0];
            sum += get(x - 1, y + 1) * matrix[0, 2];
            sum += get(x, y - 1)     * matrix[1, 0];
            sum += get(x + 1, y - 1) * matrix[2, 0];
            sum += get(x + 1, y + 1) * matrix[2, 2];
            sum += get(x, y + 1)     * matrix[1, 2];
            sum += get(x + 1, y)     * matrix[2, 1];

            return (byte)(sum / 9.0);
        }
    }
}
