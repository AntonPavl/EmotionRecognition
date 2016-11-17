using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageRecognition.Extends
{
    public static class PixelExtend
    {
        public static byte GetGray(this Pixel p)
        {
            return (byte)((p.Red + p.Blue + p.Green) / 3);
        }
        public static void ToGray(this Pixel p)
        {
            var gray = (byte)(p.Blue*0.11f + p.Green*0.59f + p.Red*0.3f);
            p.Red = gray;
            p.Blue = gray;
            p.Green = gray;
        }
    }
}
