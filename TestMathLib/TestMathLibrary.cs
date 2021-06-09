using System;
using TestingMathLibrary;
using Xunit;

namespace TestMathLib
{
    public class TestMathLibrary
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(6, 2, 8)]
        [InlineData(-6, 2, -4)]
        [InlineData(6, -6, 0)]
        [InlineData(5, 0, 5)]
        [InlineData(-103, -3, -106)]
        public void TestAdd(int i, int j, int ans)
        {
            var mathLib = new MathLib();
            Assert.Equal(ans, mathLib.Add(i, j));
        }
        [Theory]
        [InlineData(5, 2, 3)]
        [InlineData(6, 2, 4)]
        [InlineData(-6, 2, -8)]
        [InlineData(6, -6, 12)]
        [InlineData(5, 0, 5)]
        [InlineData(-103, -3, -100)]
        public void TestSubt(int i, int j, int ans)
        {
            var mathLib = new MathLib();
            Assert.Equal(ans, mathLib.Subtract(i, j));
        }
        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(6, 2, 12)]
        [InlineData(-6, 2, -12)]
        [InlineData(6, -6, -36)]
        [InlineData(5, 0, 0)]
        [InlineData(-10, -3, 30)]
        public void TestMult(int i, int j, int ans)
        {
            var mathLib = new MathLib();
            Assert.Equal(ans, mathLib.Multiply(i, j));
        }
        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(16, -2, -8)]
        [InlineData(-9, 2, -4)]
        [InlineData(0, -6, 0)]
        [InlineData(1, 0, 0)]
        [InlineData(-102, -3, 34)]
        public void TestDiv(int i, int j, int ans)
        {
            var mathLib = new MathLib();
            if (j == 0)
            {
                Assert.ThrowsAny<DivideByZeroException>(() => mathLib.Divide(i, j));
                return;
            }
            Assert.Equal(ans, mathLib.Divide(i, j));
        }
        [Theory]
        [InlineData(13, 5, 3)]
        [InlineData(6, 2, 0)]
        [InlineData(-16, 7, -2)]
        [InlineData(36, -6, 0)]
        [InlineData(7, -5, 2)]
        [InlineData(-103, -3, -1)]
        public void TestMod(int i, int j, int ans)
        {
            var mathLib = new MathLib();
            Assert.Equal(ans, mathLib.Modulo(i, j));
        }
    }
}