using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageRecognition;

namespace ImageRecognition.Filters.Implementations
{
    public class BinaryFilter : IFilter
    {
        public Image Apply(Image img)
        {
            var image = new Image(img);

            for (int i = 0; i < image.PixelCounts; i++)
            {
                var pixel = image.Pixels[i];

                var y = 0.3 * pixel.Red + 0.59 * pixel.Green + 0.11 * pixel.Blue;

                pixel.Blue = (byte)(y > 125 ? 255 : 0);
                pixel.Green = (byte)(y > 125 ? 255 : 0);
                pixel.Red   = (byte)(y > 125 ? 255 : 0);

                image.Pixels[i] = pixel;
            }

            return image;
        }
    }
}
