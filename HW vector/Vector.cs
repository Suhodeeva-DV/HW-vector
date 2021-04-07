using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_vector
{
    public class Vector
    {
        public int x;
        public int y;
        public int z;

        public Vector(int vX, int vY, int vZ)
        {
            x = vX;
            y = vY;
            z = vZ;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Вектор с координатами ({x};{y};{z})");
        }

        public double Length()
        {
            double l = Math.Sqrt(x * x + y * y + z * z);
            return l;
        }

    }
}
