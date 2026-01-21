using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1653 : IProblem
    {
        public bool Test()
        {
            var s = "aababbab";

            var expected = 2;

            var result = MinimumDeletions(s);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinimumDeletions(string s)
        {
            var n = s.Length;
            var bs = 0;
            var dp = 0;
            for (int i = 0; i < n; ++i)
            {
                if (s[i] == 'b')
                    bs++;
                else
                    dp = Math.Min(dp + 1, bs);
            }

            return dp;
        }
    }
}
