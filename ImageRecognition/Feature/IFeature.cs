using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageRecognition.Feature
{
    public interface IFeature
    {
        Rectangle Frame { get; }
        int ComputeValue(Point WinTopLeft, float SizeRatio, Image Image);
        int ComputeValue(Image Image);
    }
}
