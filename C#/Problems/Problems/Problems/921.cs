using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _921 : IProblem
    {
        public bool Test()
        {
            var s = "())";

            var expected = 1;

            var result = MinAddToMakeValid(s);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinAddToMakeValid(string s)
        {
            var result = 0;
            var cur = 0;
            foreach (var c in s)
            {
                if (c == '(')
                    cur++;
                else
                {
                    if (cur == 0)
                        result++;
                    else
                        cur--;
                }
            }

            return result + cur;
        }
    }
}
