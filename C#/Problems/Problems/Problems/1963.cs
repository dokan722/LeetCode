using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1963 : IProblem
    {
        public bool Test()
        {
            var s = "][][";

            var expected = 1;

            var result = MinSwaps(s);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinSwaps(string s)
        {
            var cur = 0;
            var result = 0;
            foreach (var c in s)
            {
                if (c == ']')
                    cur--;
                else
                    cur++;
                if (cur < 0)
                {
                    result++;
                    cur += 2;
                }
            }

            return result;
        }
    }
}
