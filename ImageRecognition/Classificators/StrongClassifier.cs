using ImageRecognition.Feature;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ImageRecognition.Classificators
{
    public class StrongClassifier
    {
        public WeakClassifier[] Classifiers;

        public double GlobalAlpha;
        public StrongClassifier(WeakClassifier[] Classifiers)
        {
            this.Classifiers = Classifiers;

            Func<double, WeakClassifier, double> sum = (acc, classifier) =>
                acc + classifier.Alpha;

            this.GlobalAlpha = this.Classifiers.Aggregate(0.0, sum);
        }

        public static StrongClassifier LoadFromFile(string Path)
        {
            var asm = Assembly.GetExecutingAssembly();

            Func<string, WeakClassifier> RestoreClassifier = (str) => {
                string[] vals = str.Split(';');

                var alpha = double.Parse(vals[0]);
                var threshold = int.Parse(vals[1]);
                var parity = sbyte.Parse(vals[2]);
                var temp = asm.GetType("ImageRecognition.Feature.TwoVerticalRectanglesFeature");
                var featureType = asm.GetType(vals[3]);
                //if (!(featureType is IFeature)) { Console.WriteLine(featureType);
                //	throw new Exception("Invalid feature type"); }

                var featureX = int.Parse(vals[4]);
                var featureY = int.Parse(vals[5]);
                var featureWidth = int.Parse(vals[6]);
                var featureHeight = int.Parse(vals[7]);
                var featureFrame = new Rectangle(new Point(featureX, featureY),new Size(featureWidth,featureHeight));

                var feature = (IFeature)Activator.CreateInstance(featureType, featureFrame);

                return new WeakClassifier(alpha, threshold, parity, feature);
            };

            var classifiers = File.ReadAllLines(Path).Select(RestoreClassifier)
                                                     .ToArray();

            return new StrongClassifier(classifiers);
        }
        public bool Check(Window Win, Image Image)
        {
            double sumValues = 0.0;
            foreach (var weakClassifier in this.Classifiers)
                sumValues += weakClassifier.GetValue(Win, Image);

            return sumValues >= this.GlobalAlpha / 2;
        }
    }
}
