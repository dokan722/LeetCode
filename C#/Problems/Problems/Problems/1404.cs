using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1404 : IProblem
    {
        public bool Test()
        {
            var s = "1101";

            var expected = 6;

            var result = NumSteps(s);

            Console.WriteLine(result);

            return result == expected;
        }

        public int NumSteps(string s)
        {
            var n = s.Length;
            var carry = 0;
            var result = 0;
            for (int i = n - 1; i > 0; --i)
            {
                var curr = s[i] == '0' ? 0 : 1;
                var val = carry + curr;
                carry = val != 0 ? 1 : 0;
                if (val == 1)
                    result += 2;
                else
                    result++;
            }

            return result + carry;
        }
    }
}
