using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_vector
{
    public class Vector
    {
        public int X;
        public int Y;
        public int Z;

        public Vector(int vX, int vY, int vZ)
        {
            X = vX;
            Y = vY;
            Z = vZ;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Вектор с координатами ({X};{Y};{Z})");
        }

        public double Length()
        {
            double l = Math.Sqrt(X * X + Y * Y + Z * Z);
            return l;
        }

        public int ScalarMultiply(Vector other)
        {
            int sm = X * other.X + Y * other.Y + Z * other.Z;
            return sm;
        }

        public Vector VectorMultiply(Vector other)
        {
            Vector newVector =  new Vector(Y * other.Z - Z * other.Y, Z * other.X - X * other.Z, X * other.Y - Y * other.X);
            return newVector;
        }

        public double Cos(Vector other)
        {
            double cos = ScalarMultiply(other) / (Length() * other.Length());
            Console.WriteLine("Косинус между векторами: " + cos);
            return cos;
        }

        public Vector Sum(Vector other)
        {
            Vector newVector = new Vector(X + other.X, Y + other.Y, Z + other.Z);
            Console.WriteLine("Сумма двух веторов: " + newVector);
            return newVector;
        }

        public Vector Subtract(Vector other)
        {
            Vector newVector = new Vector(X - other.X, Y - other.Y, Z - other.Z);
            Console.WriteLine("Разность двух веторов: " + newVector);
            return newVector;
        }

        public override string ToString()
        {
            return $"Vector {{{X}, {Y}, {Z}}}";
        }

    }
}
