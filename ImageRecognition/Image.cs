using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ImageRecognition
{
    public class Image
    {
        private List<Pixel> _pixelList = new List<Pixel>();
        private int _bmpWidth;
        private int _bmpHeight;
        private System.Drawing.Image _image;
        public int PixelCounts
        {
            get { return _pixelList.Count; }
            private set { }
        }
        public Image(string path)
        {
            using (var fs = new System.IO.FileStream(path, System.IO.FileMode.Open))
            {
                _image = System.Drawing.Image.FromStream(fs);
                LoadPixels(new Bitmap(_image));
            }
        }
        public System.Drawing.Image GetImage()
        {
            return _image;
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
            for (int counter = 0; counter <= rgbValues.Length-3; counter += 3)
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
        public Pixel this[int x, int y]
        {
            get
            {
                return _pixelList[_bmpWidth * x + y];
            }
        }
        
        public IEnumerable<Pixel> PixelEnumerable()
        {
            for (int i = 0; i < _bmpHeight; i++)
            {
                for (int j = 0; j< _bmpWidth; j++)
                {
                    yield return this[i, j];
                }
            }
        }
    }
}
