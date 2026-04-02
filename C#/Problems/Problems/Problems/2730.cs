using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2730 : IProblem
    {
        public bool Test()
        {
            var s = "52233";

            var expected = 4;

            var result = LongestSemiRepetitiveSubstring(s);

            Console.WriteLine(result);

            return expected == result;
        }

        public int LongestSemiRepetitiveSubstring(string s)
        {
            var n = s.Length;
            var bound = 0;
            var last = 0;
            var result = 0;
            for (int i = 1; i < n; ++i)
            {
                if (s[i] == s[i - 1])
                {
                    result = Math.Max(result, i - bound);
                    bound = last;
                    last = i;
                }
            }
            result = Math.Max(result, n - bound);

            return result;
        }
    }
}
