using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace Calculator.Test.Unit
{
    [TestFixture]
    public class CalculatorTest
    {
        private Calculator _uut;

        [SetUp]
        public void Setup()
        {
            _uut = new Calculator();
        }

        [TestCase(3, 3, 6)]
        [TestCase(3, -4, -1)]
        [TestCase(-0.4, -0.4, -0.8)]
        [TestCase(-4, 3, -1)]
        public void Add_sumOf2numbers(double num1, double num2, double expectedResult)
        {
            double testResult = _uut.Add(num1, num2);

            Assert.That(testResult, Is.EqualTo(expectedResult).Within(0.01));
        }

        [TestCase(1, 2U, 2)]
        [TestCase(-0.4, 4U, -1.6)]
        public void Add_sumOf1numberAccumulatedXTimes(double num1, uint times, double expectedResult)
        {

            for (int i = 0; i < times; i++)
            {
                _uut.Add(num1);
            }

            double testResult = _uut.Accumulator;

            Assert.That(testResult, Is.EqualTo(expectedResult).Within(0.01));
        }

        [TestCase(3, 3, 0)]
        [TestCase(3, -4, 7)]
        [TestCase(-0.4, -0.4, 0)]
        [TestCase(-4, 3, -7)]
        public void Subtract_differenceOf2numbers(double num1, double num2, double expectedResult)
        {
            double testResult = _uut.Subtract(num1, num2);

            Assert.That(testResult, Is.EqualTo(expectedResult).Within(0.01));
        }

        [TestCase(1, 2U, -2)]
        [TestCase(-0.4, 4U, -1.6)]
        public void Subtract_differenceOf1numberAccumulatedXTimes(double num1, uint times, double expectedResult)
        {

            for (int i = 0; i < times; i++)
            {
                _uut.Subtract(num1);
            }

            double testResult = _uut.Accumulator;

            Assert.That(testResult, Is.EqualTo(expectedResult).Within(0.01));
        }

        [TestCase(3, 3, 9)]
        [TestCase(-3, 3, -9)]
        [TestCase(4, -4, -16)]
        [TestCase(-5, -7, 35)]
        public void Multiply_productOf2numbers(double num1, double num2, double expectedResult)
        {
            double testResult = _uut.Multiply(num1, num2);

            Assert.That(testResult, Is.EqualTo(expectedResult).Within(0.01));
        }

        [TestCase(2, 3, 8)]
        [TestCase(-2, 3, -8)]
        [TestCase(4, 0, 1)]
        [TestCase(2, -2, 0.25)]
        public void Power_powerOf2numbers(double num1, double exponent, double expectedResult)
        {
            double testResult = _uut.Power(num1, exponent);

            Assert.That(testResult, Is.EqualTo(expectedResult).Within(0.01));
        }

        [TestCase(10, 0)]
        [TestCase(-32, 0)]
        [TestCase(44, -0)]
        public void Divide_divideByZero_throwTest(double num1, double num2)
        {
            DivideByZeroException ex = Assert.Throws<DivideByZeroException>(() => _uut.Divide(num1, num2));
            Assert.That("Domain error", Is.EqualTo(ex.Message));
        }

        [TestCase(10,2, 5)]
        [TestCase(0.3,22,0.0136)]
        public void Divide_divide2numbers(double num1, double num2, double expectedResult)
        {
            double testResult = _uut.Divide(num1, num2);

            Assert.That(testResult,Is.EqualTo(expectedResult).Within(0.001));
        }
        [TestCase(10)]
        [TestCase(32)]
        [TestCase(3)]
        public void ClearAccumulatorTest(double num1)
        {
            double testResult = _uut.Add(num1);
            _uut.Clear();
            testResult = _uut.Accumulator;
            Assert.That(testResult, Is.EqualTo(0));
        }
    }
}