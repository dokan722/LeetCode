using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2414 : IProblem
    {
        public bool Test()
        {
            var s = "abacaba";

            var expected = 2;

            var result = LongestContinuousSubstring(s);

            Console.WriteLine(result);

            return result == expected;
        }

        public int LongestContinuousSubstring(string s)
        {
            var n = s.Length;
            var result = 0;
            var start = 0;
            for (int i = 1; i < n; ++i)
            {
                if (s[i] - s[i - 1] != 1)
                {
                    result = Math.Max(result, i - start);
                    start = i;
                }
            }

            result = Math.Max(result, n - start);

            return result;
        }
    }
}
