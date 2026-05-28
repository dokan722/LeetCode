using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _495 : IProblem
    {
        public bool Test()
        {
            var timeSeries = new[] { 1, 4 };
            var duration = 2;

            var expected = 4;

            var result = FindPoisonedDuration(timeSeries, duration);

            Console.WriteLine(result);

            return result == expected;
        }

        public int FindPoisonedDuration(int[] timeSeries, int duration)
        {
            var n = timeSeries.Length;
            var result = 0;
            for (int i = 0; i < n - 1; ++i)
            {
                result += Math.Min(duration, timeSeries[i + 1] - timeSeries[i]);
            }

            return result + duration;
        }
    }
}
