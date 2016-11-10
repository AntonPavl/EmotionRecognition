using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageRecognition.Filters.Implementations
{
    public class NegativeFilter : IFilter
    {
        public Image Apply(Image img)
        {
            var image = new Image(img);

            for (int i = 0; i < image.PixelCounts; i++)
            {
                var pixel = image.Pixels[i];

                pixel.Blue  = (byte)(255 - pixel.Blue);
                pixel.Green = (byte)(255 - pixel.Green);
                pixel.Red   = (byte)(255 - pixel.Red);

                image.Pixels[i] = pixel;
            }

            return image;
        }
    }
}
