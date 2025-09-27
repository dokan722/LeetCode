using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1701 : IProblem
    {
        public bool Test()
        {
            var customers = new[] { new[] { 5, 2 }, new[] { 5, 4 }, new[] { 10, 3 }, new[] { 20, 1 } };

            var expected = 3.25;

            var result = AverageWaitingTime(customers);

            Console.WriteLine(result);

            return Math.Abs(expected - result) < 1e-5;
        }
        public double AverageWaitingTime(int[][] customers)
        {
            var n = customers.Length;
            var cTime = 0;
            long totalWait = 0;
            foreach (var customer in customers)
            {
                cTime = Math.Max(cTime, customer[0]);
                cTime += customer[1];
                totalWait += cTime - customer[0];
            }

            return totalWait / (double)n;
        }
    }
}
