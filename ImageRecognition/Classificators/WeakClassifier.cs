using ImageRecognition.Feature;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageRecognition.Classificators
{
    public class WeakClassifier
    {
        public double Alpha;

        public int Threshold;
        public sbyte Parity;

        public IFeature Feature;
        public WeakClassifier(double Alpha, int Threshold, sbyte Parity, IFeature Feature)
        {
            this.Alpha = Alpha;
            this.Threshold = Threshold;
            this.Parity = Parity;
            this.Feature = Feature;
        }
        public bool Check(Window Win, Image Image)
        {
            var featureValue = this.Feature.ComputeValue(Win.TopLeft, Win.SizeRatio, Image);
            var sizedValue = (int)(featureValue / (Win.SizeRatio * Win.SizeRatio));
            var normalizedValue = NormalizeFeature(sizedValue, Win.Deviation);

            return this.Parity * normalizedValue < this.Parity * this.Threshold;
        }

        public static int NormalizeFeature(int FeatureValue, int Derivation)
        {
            return (FeatureValue * 40) / Derivation;
        }

        public double GetValue(Window Win, Image Image)
        {
            if (this.Check(Win, Image))
                return this.Alpha;
            else
                return 0;
        }

    }
}
