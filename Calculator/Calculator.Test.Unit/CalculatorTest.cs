using System;
using NUnit.Framework;

namespace Calculator.TestUnit
{
    [TestFixture]
    public class CalculatorTest
    {
        private Calculator uut;

        [SetUp]
        public void Setup()
        {
            uut = new Calculator();
        }
        
        [Test]
        public void Add_sum3And3_is6()
        {
            double sum = uut.Add(3, 3);

            Assert.That(sum,Is.EqualTo(6));
        }

        [Test]
        public void Add_sum3AndMinus4_isMinus1()
        {
            double sum = uut.Add(3, -4);

            Assert.That(sum,Is.EqualTo(-1));
        }

        [TestCase(3, 3, 6)]
        [TestCase(3, -4, -1)]
        [TestCase(-0.4,-0.4,-0.8)]
        [TestCase(-4,3,-1)]
        public void Add_sumOf2numbers(double num1, double num2, double result)
        {
            double sum = uut.Add(num1, num2);

            Assert.That(sum,Is.EqualTo(result).Within(0.01));
        }

        [TestCase(3, 3, 0)]
        [TestCase(3, -4, 7)]
        [TestCase(-0.4,-0.4,0)]
        [TestCase(-4,3,-7)]
        public void Subtract_diffOf2numbers(double num1, double num2, double result)
        {
            double sum = uut.Subtract(num1, num2);

            Assert.That(sum,Is.EqualTo(result).Within(0.01));
        }

        [TestCase(3, 3, 9)]
        [TestCase(-3, 3, -9)]
        [TestCase(4, -4, -15)]
        [TestCase(-5, -7, 35)]
        public void Multiply_prodOf2numbers(double num1, double num2, double result)
        {
            double prod = uut.Multiply(num1, num2);

            Assert.That(prod,Is.EqualTo(result).Within(0.01));
        }

    }
}