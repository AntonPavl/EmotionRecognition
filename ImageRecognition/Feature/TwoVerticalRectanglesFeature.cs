using ImageRecognition.Extends;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageRecognition.Feature
{
    public class TwoVerticalRectanglesFeature : IFeature
    {
        public const int minWidth = 1;
        public const int minHeight = 2;

        public Rectangle Frame { get; private set; }

        public TwoVerticalRectanglesFeature(Rectangle Frame)
        {
            this.Frame = Frame;
        }

        public int ComputeValue(Point WinTopLeft, float SizeRatio, Image Image)
        {


            var scaledFrame = this.Frame.Scale(SizeRatio);
            var topLeft = scaledFrame.TopLeft().NestedPoint(WinTopLeft);
            if (topLeft.X + scaledFrame.Width > Image.Width || topLeft.Y + scaledFrame.Height > Image.Height) return 0; //!!!
            var rectsWidth = scaledFrame.Width;
            var rectsHeight = scaledFrame.Height / 2;

            var aCoords = topLeft;
            var bCoords = aCoords.Translate(rectsWidth, 0);

            var cCoords = aCoords.Translate(0, rectsHeight);
            var dCoords = cCoords.Translate(rectsWidth, 0);

            var eCoords = cCoords.Translate(0, rectsHeight);
            var fCoords = eCoords.Translate(rectsWidth, 0);

            var a = Image.GetValue(aCoords);
            var b = Image.GetValue(bCoords);
            var c = Image.GetValue(cCoords);
            var d = Image.GetValue(dCoords);
            var e = Image.GetValue(eCoords);
            var f = Image.GetValue(fCoords);

            var sumR1 = d - (b + c) + a;
            var sumR2 = f - (d + e) + c;

            return (int)(sumR2 - sumR1);
        }
        public int ComputeValue(Image Image)
        {
            var topLeft = new Point(0, 0);
            return this.ComputeValue(topLeft, 1f, Image);
        }

    }
}
