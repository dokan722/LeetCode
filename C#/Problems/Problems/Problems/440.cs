using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _440 : IProblem
    {
        public bool Test()
        {
            var n = 681692778;
            var k = 351251360;

            var expected = 416126219;

            var result = FindKthNumber(n, k);

            Console.WriteLine(result);

            return expected == result;
        }


        public int FindKthNumber(int n, int k)
        {
            int curr = 1;
            k--;

            while (k > 0)
            {
                long step = CountSteps(n, curr, curr + 1);
                if (step <= k)
                {
                    curr++;
                    k -= (int)step;
                }
                else
                {
                    curr *= 10;
                    k--;
                }
            }

            return curr;
        }

        private long CountSteps(int n, long p1, long p2)
        {
            long steps = 0;
            while (p1 <= n)
            {
                steps += long.Min((long)(n + 1), p2) - p1;
                p1 *= 10;
                p2 *= 10;
            }
            return steps;
        }
    }
}
