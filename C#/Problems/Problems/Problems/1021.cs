
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1021 : IProblem
    {
        public bool Test()
        {
            var s = "(()())(())";

            var expected = "()()()";

            var result = RemoveOuterParentheses(s);

            Console.WriteLine(result);

            return result == expected;
        }

        public string RemoveOuterParentheses(string s)
        {
            var n = s.Length;
            var result = new StringBuilder();
            var d = 0;
            var start = 0;
            for (int i = 0; i < n; ++i)
            {
                if (s[i] == '(')
                    d++;
                else
                    d--;
                if (d == 0)
                {
                    result.Append(s.Substring(start + 1, i - start - 1));
                    start = i + 1;
                }
            }

            return result.ToString();
        }
    }
}
