using System;
using CalculationLib;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculation calc = new Calculation();
            double a = 25;
            double b = 5;
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);
            Console.WriteLine("a + b = {0}", calc.Plus(a, b));
            Console.WriteLine("a - b = {0}", calc.Minus(a, b));
            Console.WriteLine("a / b = {0}", calc.Divide(a, b));
            Console.WriteLine("a * b = {0}", calc.Multiply(a, b));
            Console.ReadKey();
        }
    }
}
