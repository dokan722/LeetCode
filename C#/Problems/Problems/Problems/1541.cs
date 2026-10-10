using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1541 : IProblem
    {
        public bool Test()
        {
            var s = "(()))";

            var expected = 1;

            var result = MinInsertions(s);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinInsertions(string s)
        {
            var n = s.Length;
            var d = 0;
            var result = 0;
            for (int i = 0; i < n; ++i)
            {
                if (s[i] == '(')
                    d++;
                if (s[i] == ')')
                {
                    if (i < n - 1 && s[i + 1] == ')')
                        i++;
                    else
                        result++;
                    if (d == 0)
                        result++;
                    else
                        d--;
                }
            }
            return result + 2 * d;
        }
    }
}
