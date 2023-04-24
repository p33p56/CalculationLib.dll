using System;

namespace CalculationLib
{
    public class Calculation
    {
        public double Plus(double a, double b)
        {
            return a + b;
        }

        public double Minus(double a, double b)
        {
            return a - b;
        }

        public double Divide(double a, double b)
        {
            if (b == 0)
            {

            }
            return a / b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }
    }
}