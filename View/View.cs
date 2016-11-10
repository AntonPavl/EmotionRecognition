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
            var m = new int[3, 3];

            m[0, 0] = 1;
            m[1, 0] = 1;
            m[0, 1] = 1;
            m[0, 2] = 1;
            m[1, 1] = 1;
            m[1, 2] = 1;
            m[2, 0] = 1;
            m[2, 1] = 1;
            m[2, 2] = 1;

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
    }
}
