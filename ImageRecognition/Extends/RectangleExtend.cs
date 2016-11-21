using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageRecognition.Extends
{
    public static class RectangleExtend
    {
        public static Rectangle Scale(this Rectangle r,double sizeRatio)
        {
            var scaledTopLeft = new Point(r.X,r.Y).Scale(sizeRatio);
            return new Rectangle(scaledTopLeft, new Size((int)(r.Width * sizeRatio), (int)(r.Height * sizeRatio)));
        }
        public static Point TopLeft(this Rectangle r)
        {
            return new Point(r.X, r.Y);
        }
        public static Point Scale(this Point p, double sizeRatio)
        {
            return new Point((int)(p.X * sizeRatio), (int)(p.Y * sizeRatio));
        }

        public static Point NestedPoint(this Point o,Point Parent)
        {
            return new Point(o.X + Parent.X, o.Y + Parent.Y);
        }

        public static Point Translate(this Point p,int DX, int DY)
        {
            return new Point(p.X + DX, p.Y + DY);
        }
    }
}
