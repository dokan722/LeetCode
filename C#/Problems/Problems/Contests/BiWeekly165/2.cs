using Problems.Problems;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Contests.BiWeekly165
{
    public class _2 : IProblem
    {
        public bool Test()
        {
            var arrivals = new[] { 7, 3, 9, 9, 7, 3, 5, 9, 7, 2, 6, 10, 9, 7, 9, 1, 3, 6, 2, 4, 6, 2, 6, 8, 4, 8, 2, 7, 5, 6 };
            var w = 10;
            var m = 1;

            var expected = 13;

            var result = MinArrivalsToDiscard(arrivals, w, m);

            Console.WriteLine(result);

            return expected == result;
        }

        public int MinArrivalsToDiscard(int[] arrivals, int w, int m)
        {
            var n = arrivals.Length;
            var counts = new Dictionary<int, int>();
            var result = 0;
            var discards = new Queue<int>();
            for (int i = 0; i < n; ++i)
            {
                if (i >= w)
                {
                    if (!discards.TryPeek(out var top) || top != i - w)
                        counts[arrivals[i - w]]--;
                    else
                    {
                        discards.Dequeue();
                    }
                }
                if (!counts.ContainsKey(arrivals[i]))
                    counts[arrivals[i]] = 1;
                else
                {
                    if (counts[arrivals[i]] < m)
                        counts[arrivals[i]]++;
                    else
                    {
                        discards.Enqueue(i);
                        result++;
                    }
                }
            }

            return result;
        }
    }
}
