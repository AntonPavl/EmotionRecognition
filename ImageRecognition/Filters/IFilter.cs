using ImageRecognition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageRecognition.Filters
{
    public interface IFilter
    {
        Image Apply(Image img);
    }
}
