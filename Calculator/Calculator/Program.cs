using System;

namespace Calculator
{
    static class Program
    {
        private static void Main()
        {
            var calc = new Calculator();

            Console.WriteLine("Testing Add:");
            Console.WriteLine("3 + 3 = " + calc.Add(3, 3));
            Console.WriteLine("(-3) + 3 = " + calc.Add(-3, 3));
            Console.WriteLine("3 + (-3) = " + calc.Add(3, -3));
            Console.WriteLine("(-3) + (-3) = " + calc.Add(-3, -3));

            Console.WriteLine("\nTesting Subtract:");
            Console.WriteLine("3 - 3 = " + calc.Subtract(3, 3));
            Console.WriteLine("(-3) - 3 = " + calc.Subtract(-3, 3));
            Console.WriteLine("3 - (-3) = " + calc.Subtract(3, -3));
            Console.WriteLine("(-3) - (-3) = " + calc.Subtract(-3, -3));

            Console.WriteLine("\nTesting Multiply:");
            Console.WriteLine("3 * 3 = " + calc.Multiply(3, 3));
            Console.WriteLine("(-3) * 3 = " + calc.Multiply(-3, 3));
            Console.WriteLine("3 * (-3) = " + calc.Multiply(3, -3));
            Console.WriteLine("(-3) * (-3) = " + calc.Multiply(-3, -3));

            Console.WriteLine("\nTesting Power:");
            Console.WriteLine("3 ^ 3 = " + calc.Power(3, 3));
            Console.WriteLine("(-3) ^ 3 = " + calc.Power(-3, 3));
            Console.WriteLine("3 ^ (-3) = " + calc.Power(3, -3));
            Console.WriteLine("(-3) ^ (-3) = " + calc.Power(-3, -3));

            calc.Clear();

            Console.WriteLine("\n3 + 3 = " + calc.Add(3, 3));
            Console.WriteLine("ans + 5 = " + calc.Add(5));

            Console.ReadKey();
        }
    }
}