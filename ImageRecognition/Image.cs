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
        private List<Pixel> _pixelList = new List<Pixel>();
        private int _bmpWidth;
        private int _bmpHeight;
        private SysImage _image;

        public int PixelCounts => _pixelList.Count;
        public SysImage InnerImage => _image;

        public Pixel this[int x, int y] => _pixelList[_bmpWidth * x + y];

        public Image(string path)
        {
            using (var fs = new FileStream(path, FileMode.Open))
            {
                _image = SysImage.FromStream(fs);
                LoadPixels(new Bitmap(_image));
            }
        }

        private void LoadPixels(Bitmap bmp)
        {
            BitmapData bmpData = bmp.LockBits(
                new Rectangle(0, 0, bmp.Width, bmp.Height),
                ImageLockMode.ReadWrite,
                PixelFormat.Format24bppRgb);

            _bmpHeight = bmp.Height;
            _bmpWidth = bmp.Width;

            int numBytes = bmpData.Stride * bmp.Height;
            byte[] rgbValues = new byte[numBytes];
            Marshal.Copy(bmpData.Scan0, rgbValues, 0, numBytes);

            for (int counter = 0; counter <= rgbValues.Length-1; counter += 3)
            {
                _pixelList.Add(new Pixel
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
            for (int i = 0; i < _bmpHeight; i++)
            {
                for (int j = 0; j < _bmpWidth; j++)
                {
                    yield return this[i, j];
                }
            }
        }
    }
}
