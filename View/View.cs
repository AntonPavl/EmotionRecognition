using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using SysImage = System.Drawing.Image;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageRecognition;
using System.IO;
using ImageRecognition.Filters.Implementations;
using ImageRecognition.Classificators;
using ImageRecognition.Detectors;

namespace View
{
    public partial class View : Form
    {
        private Image _image;
        private Image _originalImage;

        public View()
        {
            InitializeComponent();
        }

        private void View_Load(object sender, EventArgs e)
        {
            brightBar.Value = 127;
        }

        private void openImageButton_Click(object sender, EventArgs e)
        {
            if (openImageDialog.ShowDialog() == DialogResult.OK)
            {
                using (var fs = new FileStream(openImageDialog.FileName, FileMode.Open))
                    mainImageBox.Image = SysImage.FromStream(fs);

                _originalImage = new Image(openImageDialog.FileName);
                _image = new Image(openImageDialog.FileName);
            }
        }

        private void openRGBChartButton_Click(object sender, EventArgs e)
        {
            var form = new ViewRGBChart(_image);
            form.Show();
        }
        private void negativeFilter_Click(object sender, EventArgs e)
        {
            _image = _image.Apply(new NegativeFilter());
            mainImageBox.Image = _image.GetImage();
        }

        private void lowFreqFilter_Click(object sender, EventArgs e)
        {
            var m = new int[,] { { 1,1,1 }, { 1,1,1 }, { 1,1,1 } };
            _image = _image.Apply(new LowFreqFilter(m));

            mainImageBox.Image = _image.GetImage();
        }

        private void binaryFilter_Click(object sender, EventArgs e)
        {
            _image = _image.Apply(new BinaryFilter(),brightBar.Value);
            mainImageBox.Image = _image.GetImage();
        }

        private void openOriginalImage_Click(object sender, EventArgs e)
        {
            _image = new Image(_originalImage);
            mainImageBox.Image = _image.GetImage();
        }

        private int ind = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (openClassDialog.ShowDialog() == DialogResult.OK)
            {
                _image.Apply(new GrayFilter());
                var classifier = StrongClassifier.LoadFromFile(openClassDialog.FileName);
                var detector = new Detector(_image, classifier);
                var i = 0;
                foreach (var item in detector.Detect().Where(x => x.Deviation>51))
                {
                   // i++;
                    //if (i > 5) break;
                    _image.DrawRectangle(item.ToRectangle());
                }
                Console.WriteLine(i);
               // _image.DrawRectangle(new System.Drawing.Rectangle(100,100,100,100));
                mainImageBox.Image = _image.GetImage();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            _image.Apply(new GrayFilter());
            mainImageBox.Image = _image.GetImage();
        }
    }
}
