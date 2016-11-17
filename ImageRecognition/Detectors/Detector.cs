using ImageRecognition.Classificators;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageRecognition.Detectors
{
    public class Detector
    {
        public readonly Image Image;
        public readonly StrongClassifier Classifier;
        public readonly Image SquaredImage;
        public Detector(Image Image, Image SquaredImage, StrongClassifier Classifier)
        {
            this.Image = Image;
            this.Classifier = Classifier;
            this.SquaredImage = SquaredImage;
        }
        public Detector(Image Image, StrongClassifier Classifier): 
            this(new Image(Image), new Image(Image, (pix) => (long)pix*pix),Classifier)
        {
        }
        public IEnumerable<Rectangle> Detect()
        {
            Func<Window, bool> check = (win) =>
                this.Classifier.Check(win, this.Image);

            return Window.ListWindows(this.Image, this.SquaredImage)
                         .Where(check)
                         .Select((win) => win.ToRectangle());
        }
    }
}
