using ImageRecognition.Extends;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageRecognition.Filters.Implementations
{
    public class GrayFilter : IFilter
    {
        public Image Apply(Image img)
        {
            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    img[i, j].ToGray();
                }
            }
            return img;
        }
    }
}
