using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageRecognition;
namespace View
{
    public partial class View : Form
    {
        private ImageRecognition.Image _image;
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
                _image = new ImageRecognition.Image(openImageDialog.FileName);
                mainImageBox.Image = _image.InnerImage;  
            }
        }

        private void openRGBChartButton_Click(object sender, EventArgs e)
        {
            if (_image != null)
            { 
                ViewRGBChart form = new ViewRGBChart(_image);
                form.Show();
            }
        }

    }
}
