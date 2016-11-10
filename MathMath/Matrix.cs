using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMath
{
    public class Matrix
    {
        int size;
        int[,] array;
        public Matrix(int[,] arr)
        {
            array = arr;
            size = (int)Math.Sqrt(arr.Length);
        }
        public byte Result(int px, int py, Func<int, int, byte> get)
        {
            var sum = 0;
            for (int x = -size / 2; x <= size / 2; x++)
            {
                for (int y = -size / 2; y <= size / 2; y++)
                {
                    sum += get(px - x, py - y) * array[size / 2 + x, size / 2 + x];
                }
            }
            sum /= size * size;
            return (byte)sum;
        }
    }
}
