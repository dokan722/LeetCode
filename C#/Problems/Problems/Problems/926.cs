using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _926 : IProblem
    {
        public bool Test()
        {
            var s = "00110";

            var expected = 1;

            var result = MinFlipsMonoIncr(s);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinFlipsMonoIncr(string s)
        {
            var ones = 0;
            var result = 0;
            foreach (var c in s)
            {
                if (c == '1')
                    ones++;
                else
                    result = Math.Min(result + 1, ones);
            }

            return result;
        }
    }
}
