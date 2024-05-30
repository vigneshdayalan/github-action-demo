using System;

namespace SimpleCalculator
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public double Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Division by zero is not allowed.");
            }
            return (double)a / b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.WriteLine("Addition: " + calculator.Add(5, 3));
            Console.WriteLine("Subtraction: " + calculator.Subtract(5, 3));
            Console.WriteLine("Multiplication: " + calculator.Multiply(5, 3));
            Console.WriteLine("Division: " + calculator.Divide(5, 3));
        }
    }
}
