using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2073 : IProblem

    {
        public bool Test()
        {
            var tickets = new[] { 5, 1, 1, 1 };
            var k = 0;

            var expected = 8;

            var result = TimeRequiredToBuy(tickets, k);

            Console.WriteLine(result);

            return expected == result;
        }

        public int TimeRequiredToBuy(int[] tickets, int k)
        {
            var n = tickets.Length;
            var bar = tickets[k];
            var result = bar;
            for (int i = 0; i < k; ++i)
                result += Math.Min(tickets[i], bar);
            for (int i = k + 1; i < n; ++i)
                result += Math.Min(tickets[i], bar - 1);

            return result;
        }
    }
}
