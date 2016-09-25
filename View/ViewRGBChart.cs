using System.Windows.Forms;
using ImageRecognition;

namespace View
{
    public partial class ViewRGBChart : Form
    {
        public ViewRGBChart(Image image)
        {
            InitializeComponent();
            DrawChart(image);
        }

        private void DrawChart(Image image)
        {
            imageChart.Series[0].Points.Clear();
            imageChart.Series[1].Points.Clear();
            imageChart.Series[2].Points.Clear();

            var R = new int[256];
            var G = new int[256];
            var B = new int[256];

            foreach (var pixel in image)
            {
                R[pixel.Red] += 1;
                G[pixel.Green] += 1;
                B[pixel.Blue] += 1;
            }

            for (int i = 0; i < 256; i++)
            {
                imageChart.Series[0].Points.AddXY(i, R[i]);
                imageChart.Series[1].Points.AddXY(i, G[i]);
                imageChart.Series[2].Points.AddXY(i, B[i]);

                //chart1.Series[0].Points.AddXY(i, G[i]);
                //chart2.Series[0].Points.AddXY(i, B[i]);
            }
        }
    }
}
