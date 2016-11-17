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
            /*
			 * a ------- b ------- c
			 * -         -         -
			 * -   R1    -    R2   -
			 * -         -         -
			 * d ------- e ------- f
			 * S(R1) = e - (b + d) + a
			 * S(R2) = f - (c + e) + b
			 */

            var scaledFrame = this.Frame.Scale(SizeRatio);
            var topLeft = scaledFrame.TopLeft().NestedPoint(WinTopLeft);
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
