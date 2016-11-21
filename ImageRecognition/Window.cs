using ImageRecognition.Extends;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageRecognition
{
	public class Window
	{
		public Point TopLeft;

		public float SizeRatio;

		private Image _image;

		public readonly int Deviation;

		public int Width
		{
			get
			{
				return (int)(Config.WindowWidth * SizeRatio);
			}
		}
		public int Height
		{
			get
			{
				return (int)(Config.WindowHeight * SizeRatio);
			}
		}

		public Window(Point TopLeft, float SizeRatio, Image Image, Image SquaredImage )
		{
			this.TopLeft = TopLeft;
			this.SizeRatio = SizeRatio;
			this._image = Image;
			this.Deviation = 0;
			this.Deviation = this.GetDeviation(Image, SquaredImage);

		}
		private int GetDeviation(Image Image, Image SquaredImage)
		{

			var nPixs = this.Width * this.Height;
           // if (Width > Image.Width || Height > Image.Height) return 1;
			var aCoords = this.TopLeft;
			var bCoords = aCoords.Translate(this.Width, 0);
			var cCoords = aCoords.Translate(0, this.Height);
			var dCoords = cCoords.Translate(this.Width, 0);

			var a = Image.GetValue(aCoords);
			var b = Image.GetValue(bCoords);
			var c = Image.GetValue(cCoords);
			var d = Image.GetValue(dCoords);

			var squaredA = SquaredImage.GetValue(aCoords);
			var squaredB = SquaredImage.GetValue(bCoords);
			var squaredC = SquaredImage.GetValue(cCoords);
			var squaredD = SquaredImage.GetValue(dCoords);

			var sum = d - (b + c) + a;
			var squaredSum = squaredD - (squaredB + squaredC) + squaredA;

			var avg = sum / nPixs;

			var variance = squaredSum / nPixs - avg * avg;

            if (variance > 0)
                return (int)Math.Sqrt(variance);
            else
                return 1;
        }

		public Rectangle ToRectangle()
		{
			return new Rectangle(this.TopLeft, new Size(this.Width, this.Height));
		}

		public static IEnumerable<Window> ListWindows(Image Image, Image SquaredImage)
		{
            var maxX = Image.Width - Config.WindowWidth;
            var maxY = Image.Height - Config.WindowHeight;

            for (var x = Config.WindowStartX; x <= maxX; x += Config.WindowDX)
            {
                for (var y = Config.WindowStartY; y <= maxY; y += Config.WindowDY)
                {
                    var maxWidth = Image.Width - x;
                    var maxHeight = Image.Height - y;
                    var width = Config.WindowWidth;
                    var height = Config.WindowHeight;
                    var ratio = 1f;
                    //yield return new Window(new Point(x, y), ratio, Image, SquaredImage); //!!
                    while (width <= maxWidth && height <= maxHeight)
                    {
                        yield return new Window(new Point(x, y), ratio, Image, SquaredImage);

                        ratio *= Config.WindowScale;
                        width = (int)(Config.WindowWidth * ratio);
                        height = (int)(Config.WindowHeight * ratio);
                    }
                }
            }
        }

    }
}
