using System;

namespace yohan_challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            calculator.Compute();
            calculator.PrintSolution();
            Console.ReadLine();
        }
    }
}
