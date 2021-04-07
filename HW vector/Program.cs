using System;

namespace HW_vector
{
    class Program
    {
        static void Main(string[] args)
        {
            var v1 = new Vector(2, 3, 6);
            var v2 = new Vector(1, 5, 2);
            var v1v2 = new TwoVectors(v1, v2);

            Vectors(v1, v2);
            OperationWithTwoVectors(v1v2);
        }

        static void Vectors(Vector v1, Vector v2)
        {
            v1.DisplayInfo();
            var lengthV1 = v1.Length();
            Console.WriteLine("Длина вектора: " + lengthV1);

            v2.DisplayInfo();
            var lengthV2 = v2.Length();
            Console.WriteLine("Длина вектора: " + lengthV2);
        }

        static void OperationWithTwoVectors(TwoVectors vv)
        {
            vv.ScalarMultiply();
            vv.VectorMultiply();
            vv.Cos();
            vv.Sum();
            vv.Subtract();
        }













    }
}
