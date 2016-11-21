using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMath
{
    public static class Matrixs
    {
        public static int[,] Laplacian3x3
        {
            get
            {
                return new int[,]
                { { -1, -1, -1,  },
                  { -1,  8, -1,  },
                  { -1, -1, -1,  }, };
            }
        }

        public static int[,] Laplacian5x5
        {
            get
            {
                return new int[,]
                { { -1, -1, -1, -1, -1, },
                  { -1, -1, -1, -1, -1, },
                  { -1, -1, 24, -1, -1, },
                  { -1, -1, -1, -1, -1, },
                  { -1, -1, -1, -1, -1  }, };
            }
        }

        public static int[,] LaplacianOfGaussian
        {
            get
            {
                return new int[,]
                { {  0,   0, -1,  0,  0 },
                  {  0,  -1, -2, -1,  0 },
                  { -1,  -2, 16, -2, -1 },
                  {  0,  -1, -2, -1,  0 },
                  {  0,   0, -1,  0,  0 }, };
            }
        }

        public static int[,] Gaussian3x3
        {
            get
            {
                return new int[,]
                { { 1, 2, 1, },
                  { 2, 4, 2, },
                  { 1, 2, 1, }, };
            }
        }

        public static int[,] Gaussian5x5Type1
        {
            get
            {
                return new int[,]
                { { 2, 04, 05, 04, 2 },
                  { 4, 09, 12, 09, 4 },
                  { 5, 12, 15, 12, 5 },
                  { 4, 09, 12, 09, 4 },
                  { 2, 04, 05, 04, 2 }, };
            }
        }

        public static int[,] Gaussian5x5Type2
        {
            get
            {
                return new int[,]
                { {  1,   4,  6,  4,  1 },
                  {  4,  16, 24, 16,  4 },
                  {  6,  24, 36, 24,  6 },
                  {  4,  16, 24, 16,  4 },
                  {  1,   4,  6,  4,  1 }, };
            }
        }

        public static int[,] Sobel3x3Horizontal
        {
            get
            {
                return new int[,]
                { { -1,  0,  1, },
                  { -2,  0,  2, },
                  { -1,  0,  1, }, };
            }
        }

        public static int[,] Sobel3x3Vertical
        {
            get
            {
                return new int[,]
                { {  1,  2,  1, },
                  {  0,  0,  0, },
                  { -1, -2, -1, }, };
            }
        }

        public static int[,] Prewitt3x3Horizontal
        {
            get
            {
                return new int[,]
                { { -1,  0,  1, },
                  { -1,  0,  1, },
                  { -1,  0,  1, }, };
            }
        }

        public static int[,] Prewitt3x3Vertical
        {
            get
            {
                return new int[,]
                { {  1,  1,  1, },
                  {  0,  0,  0, },
                  { -1, -1, -1, }, };
            }
        }


        public static int[,] Kirsch3x3Horizontal
        {
            get
            {
                return new int[,]
                { {  5,  5,  5, },
                  { -3,  0, -3, },
                  { -3, -3, -3, }, };
            }
        }

        public static int[,] Kirsch3x3Vertical
        {
            get
            {
                return new int[,]
                { {  5, -3, -3, },
                  {  5,  0, -3, },
                  {  5, -3, -3, }, };
            }
        }
        public static int[,] RobertVerticle
        {
            get
            {
                return new int[,]
                { {  1, 0,  },
                  {  0, -1, },};
            }
        }
        public static int[,] RoberHorizontal
        {
            get
            {
                return new int[,]
                { {  0, 1,  },
                  {  -1, 0, },};
            }
        }
    }
}
