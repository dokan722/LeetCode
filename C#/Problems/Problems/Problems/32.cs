using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _32 : IProblem
    {
        public bool Test()
        {
            var s = "(()";

            var expected = 2;

            var result = LongestValidParentheses(s);

            Console.WriteLine(result);

            return expected == result;
        }

        public int LongestValidParentheses(string s)
        {
            var n = s.Length;
            var cur = 0;
            var start = 0;
            var result = 0;
            for (int i = 0; i < n; ++i)
            {
                if (s[i] == '(')
                    cur++;
                else
                    cur--;
                if (cur < 0)
                {
                    start = i + 1;
                    cur = 0;
                }
                if (cur == 0)
                    result = Math.Max(result, i - start + 1);
            }
            start = n - 1;
            cur = 0;
            for (int i = n - 1; i >= 0; --i)
            {
                if (s[i] == ')')
                    cur++;
                else
                    cur--;
                if (cur < 0)
                {
                    start = i - 1;
                    cur = 0;
                }
                if (cur == 0)
                    result = Math.Max(result, start - i + 1);
            }

            return result;
        }
    }
}
