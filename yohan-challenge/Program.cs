using System;

namespace yohan_challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator(95);
            calculator.Compute();
            calculator.PrintSolution();
            Console.ReadLine();
        }
    }
}
