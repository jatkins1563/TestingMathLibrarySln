using System;
using System.Collections.Generic;
using System.Text;

namespace TestingMathLibrary
{
    interface IMathLibrary
    {
        int Add(int i, int j);
        int Subtract(int i, int j);
        int Multiply(int i, int j);
        int Divide(int i, int j);
        int Modulo(int i, int j);
        int Power(int i, int j);
        int Square(int i);
        int Factorial(int i);
    }
}
