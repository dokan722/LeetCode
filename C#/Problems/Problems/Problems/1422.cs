using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1422 : IProblem
    {
        public bool Test()
        {
            var s = "1111";

            var expected = 3;

            var result = MaxScore(s);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MaxScore(string s)
        {
            var ones = 0;
            foreach (var c in s.Skip(1))
                if (c == '1')
                    ones++;
            var zeros = 0;
            var result = ones;
            if (s[0] == '1')
                ones++;
            foreach (var c in s.SkipLast(1))
            {
                if (c == '1')
                    ones--;
                else
                {
                    zeros++;
                    if (zeros + ones > result)
                        result = zeros + ones;
                }
            }

            return result;
        }
    }
}
