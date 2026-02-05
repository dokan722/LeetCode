using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2712 : IProblem
    {
        public bool Test()
        {
            var s = "010101";

            var expected = 9;

            var result = MinimumCost(s);

            Console.WriteLine(result);

            return result == expected;
        }

        public long MinimumCost(string s)
        {
            var n = s.Length;
            long result = 0;
            for (int i = 1; i < n; ++i)
            {
                if (s[i - 1] != s[i])
                    result += Math.Min(i, n - i);
            }
            return result;
        }
    }
}
