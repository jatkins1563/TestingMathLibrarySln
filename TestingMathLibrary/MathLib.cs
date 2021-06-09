using System;

namespace TestingMathLibrary
{
    public class MathLib : IMathLibrary
    {
        public int Add(int i, int j)
        {
            return i + j;
        }

        public int Subtract(int i, int j)
        {
            return i - j;
        }

        public int Multiply(int i, int j)
        {
            return i * j;
        }

        public int Divide(int i, int j)
        {
            //if(j == 0)
            //{
            //    throw new DivideByZeroException("Cannot divide by zero!");
            //}
            return i / j;
        }

        public int Modulo(int i, int j)
        {
            if (j == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero!");
            }
            return i % j;
        }

        public int Power(int i, int j)
        {
            var total = 1;

            for(; j > 0; j--)
            {
                total *= i;
            }

            return total;
        }

        public int Square(int i)
        {
            return i * i;
        }

        public int Factorial(int i)
        {
            if (i < 0)
            {
                throw new ArgumentOutOfRangeException("Factorial function requires positive integer input.");
            }
            var total = 1;

            for (; i > 0; i--)
            {
                total *= i;
            }

            return total;
        }
    }
}
