using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1375 : IProblem
    {
        public bool Test()
        {
            var flips = new[] { 3, 2, 4, 1, 5 };

            var expected = 2;

            var result = NumTimesAllBlue(flips);

            Console.WriteLine(result);

            return result == expected;
        }

        public int NumTimesAllBlue(int[] flips)
        {
            var n = flips.Length;
            var result = 0;
            var last = -1;
            for (int i = 0; i < n; ++i)
            {
                last = Math.Max(last, flips[i]);
                if (last == i + 1)
                    result++;
            }

            return result;
        }
    }
}
