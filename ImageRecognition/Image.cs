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

namespace ImageRecognition
{
    public class Image
    {
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
            get { return Pixels[Width * x + y]; }
            set { Pixels[Width * x + y] = value; }
        }

        public int PixelCounts => Pixels.Count;

        public Image(string path)
        {
            using (var fs = new FileStream(path, FileMode.Open))
            {
                var image = SysImage.FromStream(fs);
                LoadPixels(new Bitmap(image));
            }
        }

        public Image(Image src)
        {
            Pixels = new List<Pixel>(src.Pixels);
            Width = src.Width;
            Height = src.Height;
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

            int numBytes = bmpData.Stride * bmp.Height;
            byte[] rgbValues = new byte[numBytes];
            Marshal.Copy(bmpData.Scan0, rgbValues, 0, numBytes);

            for (int counter = 2; counter <= rgbValues.Length - 1; counter += 3)
            {
                Pixels.Add(new Pixel
                {
                    Blue = rgbValues[counter - 2],
                    Green = rgbValues[counter - 1],
                    Red = rgbValues[counter]
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
                    yield return this[i, j];
                }
            }
        }
    }
}
