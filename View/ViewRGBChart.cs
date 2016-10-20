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
    public partial class ViewRGBChart : Form
    {
        public ViewRGBChart(ImageRecognition.Image image)
        {
            InitializeComponent();
            drawChart(image);
        }
        private void drawChart(ImageRecognition.Image image)
        {
            imageChart.Series[0].Points.Clear();
            imageChart.Series[1].Points.Clear();
            imageChart.Series[2].Points.Clear();
            int[] R = new int[256];
            int[] G = new int[256];
            int[] B = new int[256];
            foreach (var pixel in image.PixelEnumerable())
            {
                R[pixel.Red] += 1;
                G[pixel.Green] += 1;
                B[pixel.Blue] += 1;
            }
            for (int i = 0; i < 256; i++)
            {
                imageChart.Series[0].Points.AddXY(i, R[i]);
                imageChart.Series[1].Points.AddXY(i, G[i]);
                //chart1.Series[0].Points.AddXY(i, G[i]);
                //chart2.Series[0].Points.AddXY(i, B[i]);
                imageChart.Series[2].Points.AddXY(i, B[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            imageChart.Series[0].Enabled = imageChart.Series[0].Enabled == false ? true : false;
        }
    }
}
