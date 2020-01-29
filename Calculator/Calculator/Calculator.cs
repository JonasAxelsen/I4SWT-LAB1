using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Calculator
{
    public class Calculator
    {
        public double Add(double a, double b)
        {
            return Accumulator = a + b;
        }

        public double Add(double a)
        {
            return Accumulator += a;
        }

        public double Subtract(double a, double b)
        {
            return Accumulator = a - b;
        }

        public double Subtract(double a)
        {
            return Accumulator -= a;
        }

        public double Multiply(double a, double b)
        {
            return Accumulator = a * b;
        }

        public double Multiply(double a)
        {
            return Accumulator *= a;
        }

        public double Power(double a, double exp)
        {
            return Accumulator = Math.Pow(a, exp);
        }

        public double Power(double exp)
        {
            return Accumulator = Math.Pow(Accumulator, exp);
        }

        public double Divide(double devidend, double divisor)
        {
            if (divisor == 0)
            {
                throw new DivideByZeroException("Domain error");
            }

            return devidend / divisor;
        }

        public double Accumulator { get; private set; } = 0;

        public void Clear()
        {
            Accumulator = 0;
        }
    }
}
