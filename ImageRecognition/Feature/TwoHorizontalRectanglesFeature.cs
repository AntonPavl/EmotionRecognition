using ImageRecognition.Extends;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageRecognition.Feature
{
    public class TwoHorizontalRectanglesFeature : IFeature
    {
        public const int minWidth = 2;
        public const int minHeight = 1;

        public Rectangle Frame { get; private set; }

        public TwoHorizontalRectanglesFeature(Rectangle Frame)
        {
            this.Frame = Frame;
        }

        public int ComputeValue(Point WinTopLeft, float SizeRatio, Image Image)
        {

            var scaledFrame = this.Frame.Scale(SizeRatio);
            var topLeft = scaledFrame.TopLeft().NestedPoint(WinTopLeft);
            if (topLeft.X + scaledFrame.Width > Image.Width || topLeft.Y + scaledFrame.Height > Image.Height) return 0; //!!!
            var rectsWidth = scaledFrame.Width / 2;
            var rectsHeight = scaledFrame.Height;

            var aCoords = topLeft;
            var bCoords = aCoords.Translate(rectsWidth, 0);
            var cCoords = bCoords.Translate(rectsWidth, 0);

            var dCoords = aCoords.Translate(0, rectsHeight);
            var eCoords = dCoords.Translate(rectsWidth, 0);
            var fCoords = eCoords.Translate(rectsWidth, 0);

            var a = Image.GetValue(aCoords);
            var b = Image.GetValue(bCoords);
            var c = Image.GetValue(cCoords);
            var d = Image.GetValue(dCoords);
            var e = Image.GetValue(eCoords);
            var f = Image.GetValue(fCoords);

            var sumR1 = e - (b + d) + a;
            var sumR2 = f - (c + e) + b;

            return (int)(sumR1 - sumR2);
        }
        public int ComputeValue(Image Image)
        {
            var topLeft = new Point(0, 0);
            return this.ComputeValue(topLeft, 1f, Image);
        }

    }
}
