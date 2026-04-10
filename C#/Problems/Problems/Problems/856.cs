using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _856 : IProblem
    {
        public bool Test()
        {
            var s = "()()";

            var expected = 2;

            var result = ScoreOfParentheses(s);

            Console.WriteLine(result);

            return result == expected;
        }

        public int ScoreOfParentheses(string s)
        {
            var n = s.Length;
            var depth = 0;
            var result = 0;
            for (int i = 0; i < n; ++i)
            {
                if (s[i] == '(')
                    depth++;
                else
                {
                    depth--;
                    if (s[i - 1] == '(')
                        result += 1 << depth;
                }
            }
            return result;
        }
    }
}
