using System;

namespace HW_vector
{
    class Program
    {
        static void Main(string[] args)
        {
            var v1 = new Vector(2, 3, 6);
            var v2 = new Vector(1, 5, 2);

            Console.WriteLine(v1);
            Console.WriteLine("Длина вектора: " + v1.Length());
            Console.WriteLine(v2);
            Console.WriteLine("Длина вектора: " + v2.Length());

            Console.WriteLine("Скалярное произведение двух векторов: " + v1.ScalarMultiply(v2));
            Console.WriteLine("В результате векторного произведения получен:" + v1.VectorMultiply(v2));
            v1.Cos(v2);
            v1.Sum(v2);
            v1.Subtract(v2);

        }
    }
}
