using System;
using System.Collections.Generic;
using System.Linq;

namespace yohan_challenge
{
    public class Calculator
    {
        public readonly Dictionary<int, List<StepTransaction>> x;
        public readonly Dictionary<int, List<int>> y;

        public Calculator()
        {
            x = new Dictionary<int, List<StepTransaction>>()
            {
                {
                    10, new List<StepTransaction>()
                    {
                        new StepTransaction(100, string.Empty, 0, Guid.NewGuid(), 10)
                    }
                }
            };

            y = new Dictionary<int, List<int>>
            {
                {1, new List<int>() { 1,12,123 }},
                {2, new List<int>() { 2,23,234 }},
                {3, new List<int>() { 3,34,345 }},
                {4, new List<int>() { 4,45 }},
                {5, new List<int>() { 5,56 }},
                {6, new List<int>() { 6,67 }},
                {7, new List<int>() { 7,78 }},
                {8, new List<int>() { 8,89 }},
                {9, new List<int>() { 9 }},
            };
        }

        public void Compute()
        {
            for (int step = 9; step >= 1; step--)
            {
                List<StepTransaction> nt = new List<StepTransaction>();
                foreach (var ynum in y[step])
                {
                    int curStep = step + ynum.GetOrderOfMagnitude();
                    foreach (var xnum in x[curStep])
                    {
                        nt.Add(new StepTransaction(xnum.PartialSum + ynum, "-", ynum, xnum.Id, curStep));
                        nt.Add(new StepTransaction(xnum.PartialSum - ynum, "+", ynum, xnum.Id, curStep));
                    }
                }

                x.Add(step, nt.ToList());
            }
        }

        public void PrintSolution()
        {
            List<StepTransaction> solutions = x[1].Where(q => q.PartialSum == 0 && q.Operand == "+").ToList();

            foreach (var item in solutions)
            {
                PrintSolutionItemRecursive(item, true);
                Console.Write($"=100{Environment.NewLine}");
            }
        }

        private void PrintSolutionItemRecursive(StepTransaction st, bool isFirst = false)
        {
            Console.Write(isFirst ? $"{st.Value}" : $"{st.Operand}{st.Value}");

            if (st.ParentStep != 10)
            {
                PrintSolutionItemRecursive(x[st.ParentStep].First(q => q.Id == st.ParentId));
            }
        }
    }
}
