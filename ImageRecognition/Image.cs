using ImageRecognition.Filters.Implementations;
using ImageRecognition.Filters;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using SysImage = System.Drawing.Image;
using ImageRecognition.Extends;

namespace ImageRecognition
{
    public class Image
    {
        public long[,] integralTable;
        public byte[,] grayPixels;

        public Func<long, long> Type;
        public int Width { get; set; }
        public int Height { get; set; }


        private List<Pixel> _pixels = new List<Pixel>();
        public List<Pixel> Pixels
        {
            get { return _pixels; }
            private set { _pixels = value; }
        }

        public Pixel this[int x, int y]
        {
            get { return Pixels[x + (Width+1) * y]; }
            set { Pixels[x + (Width+1) * y] = value; }
        }

        public int PixelCounts => Pixels.Count;

        public Image(string path)
        {
            using (var fs = new FileStream(path, FileMode.Open))
            {
                var image = SysImage.FromStream(fs);
                Type = (pix) => pix;
                integralTable = new long[image.Width, image.Height];
                grayPixels = new byte[image.Width, image.Height];
                LoadPixels(new Bitmap(image));
                ComputeIntegralImage();
            }
        }

        public Image(Image src) : this(src, (pix) => pix)
        {
        }

        public Image(Image src, Func<long, long> Type)
        {
            Pixels = new List<Pixel>(src.Pixels);
            integralTable = new long[src.Width, src.Height];
            grayPixels = src.grayPixels;
            Width = src.Width;
            Height = src.Height;
            this.Type = Type;
            ComputeIntegralImage();
        }


        public Image Apply(IFilter filter) => filter.Apply(this);

        public Image Apply(BinaryFilter filter, int extra) => filter.Apply(this, extra);

        public Bitmap GetImage()
        {
            var bitmap = Pixels.SelectMany(p => new[] { p.Blue, p.Green, p.Red }).ToArray();
            var bmp = new Bitmap(Width, Height, PixelFormat.Format24bppRgb);
            var data = bmp.LockBits(
                new Rectangle(0, 0, Width, Height),
                ImageLockMode.ReadWrite,
                PixelFormat.Format24bppRgb);

            Marshal.Copy(bitmap, 0, data.Scan0, bitmap.Length);

            bmp.UnlockBits(data);

            return bmp;
        }

        private void LoadPixels(Bitmap bmp)
        {
            BitmapData bmpData = bmp.LockBits(
                new Rectangle(0, 0, bmp.Width, bmp.Height),
                ImageLockMode.ReadWrite,
                PixelFormat.Format24bppRgb);

            Height = bmp.Height;
            Width = bmp.Width;

            byte[] rgbValues = new byte[bmpData.Stride * bmp.Height];
            Marshal.Copy(bmpData.Scan0, rgbValues, 0, rgbValues.Length);
            for (int i = 0; i < 21; i += 3)
            {
                Console.WriteLine($"RGB{i} = B{rgbValues[i]},G{rgbValues[i + 1]},R{rgbValues[i + 2]}");
            }
            for (int counter = 0; counter < rgbValues.Length; counter += 3)
            {
                Pixels.Add(new Pixel
                {
                    Blue = rgbValues[counter], 
                    Green = rgbValues[counter + 1],
                    Red = rgbValues[counter + 2]
                });
            }
            bmp.UnlockBits(bmpData);
        }
        
        public IEnumerator<Pixel> GetEnumerator()
        {
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    yield return this[j,i];
                }
            }
        }

        public long GetValue(Point Coords)
        {
            if (Coords.X == 0 || Coords.Y == 0)
                return 0L;
            else
                return this.integralTable[Coords.X - 1,Coords.Y - 1];
        }
        public void DrawRectangle(Rectangle r)
        {
            for (int i = r.X; i < r.X + r.Width; i++)
            {
                this[i,r.Y] = new Pixel()           { Blue = Config.B, Green = Config.G, Red = Config.R };
                this[i, r.Y] = new Pixel() { Blue = Config.B, Green = Config.G, Red = Config.R };
            }
            for (int i = r.Y; i < r.Y + r.Height; i++)
            {
                this[r.X, i] = new Pixel()         { Blue = Config.B, Green = Config.G, Red = Config.R };
                this[r.X+r.Width, i] = new Pixel() { Blue = Config.B, Green = Config.G, Red = Config.R };
            }

        }
        public void ComputeIntegralImage()
        {
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    this.grayPixels[i, j] = this[i, j].GetGray();
                    this.integralTable[i, j] = this.grayPixels[i, j];
                }
            }

            for (int i = 1; i < Width; i++)
            {
                this.integralTable[i, 0] += this.Type(this.grayPixels[i - 1, 0]);
            }

            for (int i = 1; i < Height; i++)
            {
                this.integralTable[0, i] += this.Type(this.grayPixels[0, i - 1]);
            }

            for (int i = 1; i < Width - 1; i++)
            {
                for (int j = 1; j < Height - 1; j++)
                {
                    this.integralTable[i, j] =
                        this.Type(this.grayPixels[i, j]) +
                        this.integralTable[i - 1, j] +
                        this.integralTable[i, j - 1] -
                        this.integralTable[i - 1, j - 1];
                }
            }
        }
    }
}
