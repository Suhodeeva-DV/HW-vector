using System;
using Xunit;

namespace HW_vector.Tests
{
    public class UnitTestVector
    {
        [Fact]
        public void LengthTest()
        {
            Vector vector = new Vector(5, 5, 5);

            double result = vector.Length();

            Assert.Equal(8.66, result, 3);
        }

        [Fact]
        public void ScalarMultiplyTest()
        {
            Vector v1 = new Vector(1, 1, -1);
            Vector v2 = new Vector(5, 5, 5);

            int result = v1.ScalarMultiply(v2);

            Assert.Equal(5, result);
        }

        [Fact]
        public void VectorMultiply()
        {
            Vector v1 = new Vector(1, 1, -1);
            Vector v2 = new Vector(5, 5, 5);

            Vector result = v1.VectorMultiply(v2);

            Assert.Equal($"Vector {{{10}, {-10}, {0}}}", result.ToString());
        }

        [Fact]
        public void CosTest()
        {
            Vector v1 = new Vector(1, 1, -1);
            Vector v2 = new Vector(5, 5, 5);

            double result = v1.Cos(v2);

            Assert.Equal(0.333, result,3);
        }

        [Fact]
        public void SumTest()
        {
            Vector v1 = new Vector(1, 1, -1);
            Vector v2 = new Vector(5, 5, 5);

            Vector result = v1.Sum(v2);

            Assert.Equal($"Vector {{{6}, {6}, {4}}}", result.ToString());
        }

        [Fact]
        public void Subtract()
        {
            Vector v1 = new Vector(1, 1, -1);
            Vector v2 = new Vector(5, 5, 5);

            Vector result = v1.Subtract(v2);

            Assert.Equal($"Vector {{{-4}, {-4}, {-6}}}", result.ToString());
        }
    }
}
