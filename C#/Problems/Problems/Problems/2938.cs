using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2938 : IProblem
    {
        public bool Test()
        {
            var s = "101";

            var expected = 1;

            var result = MinimumSteps(s);

            Console.WriteLine(result);

            return result == expected;
        }

        public long MinimumSteps(string s)
        {
            var n = s.Length;
            var l = 0;
            long result = 0;
            for (int i = 0; i < n; ++i)
            {
                if (s[i] == '0')
                {
                    result += i - l++;
                }
            }

            return result;
        }
    }
}
