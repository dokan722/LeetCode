using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3281 : IProblem
    {
        public bool Test()
        {
            var start = new[] { 2, 6, 13, 13 };
            var d = 5;

            var expected = 5;

            var result = MaxPossibleScore(start, d);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MaxPossibleScore(int[] start, int d)
        {
            var n = start.Length;
            Array.Sort(start);
            long l = int.MaxValue;
            for (int i = 1; i < n; ++i)
                l = Math.Min(l, start[i] - start[i - 1]);
            var r = l + d;
            while (l < r)
            {
                long mid = (l + r + 1) / 2;
                var poss = true;
                long curr = start[0];
                for (int i = 1; i < n; ++i)
                {
                    long gap = start[i] - curr;
                    if (gap < mid)
                    {
                        long missing = mid - gap;
                        if (missing > d)
                        {
                            poss = false;
                            break;
                        }
                        curr = start[i] + missing;
                    }
                    else
                        curr = start[i];
                }
                if (poss)
                    l = mid;
                else
                    r = mid - 1;
            }

            return (int)l;
        }
    }
}
