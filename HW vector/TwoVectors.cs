using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_vector
{
    class TwoVectors
    {
        Vector v1;
        Vector v2;
        int x1, y1, z1;
        int x2, y2, z2;

        public TwoVectors(Vector v1, Vector v2)
        {
            this.v1 = v1;
            this.v2 = v2;
            x1 = v1.CoordinatX();
            y1 = v1.CoordinatY();
            z1 = v1.CoordinatZ();
            x2 = v2.CoordinatX();
            y2 = v2.CoordinatY();
            z2 = v2.CoordinatZ();
        }

        public int ScalarMultiply()
        {
            int sm = x1 * x2 + y1 * y2 + z1 * z2;
            Console.WriteLine("Скалярное произведение двух векторов: " + sm);
            return sm;
        }

        public void VectorMultiply()
        {
            int x3 = y1 * z2 - z1 * y2;
            int y3 = z1 * x2 - x1 * z2;
            int z3 = x1 * y2 - y1 * x2;
            Vector v3 = new Vector(x3, y3, z3);
            Console.Write("В результате векторного произведения получен:");
            v3.DisplayInfo();
        }

        public void Cos()
        {
            double cos = ScalarMultiply() / (v1.Length() * v2.Length());
            Console.WriteLine("Косинус между векторами: " + cos);
        }

        public void Sum()
        {
            int x4 = x1 + x2;
            int y4 = y1 + y2;
            int z4 = z1 + z2;
            Vector v4 = new Vector(x4, y4, z4);
            Console.Write("Сумма двух веторов: ");
            v4.DisplayInfo();
        }

        public void Subtract()
        {
            int x5 = x1 - x2;
            int y5 = y1 - y2;
            int z5 = z1 - z2;
            Vector v5 = new Vector(x5, y5, z5);
            Console.Write("Разность двух веторов: ");
            v5.DisplayInfo();
        }

    }
}
