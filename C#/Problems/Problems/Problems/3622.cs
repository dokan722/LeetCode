using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3622 : IProblem
    {
        public bool Test()
        {
            var n = 99;

            var expected = true;

            var result = CheckDivisibility(n);

            return result == expected;
        }

        public bool CheckDivisibility(int n)
        {
            var prod = 1;
            var s = 0;
            var num = n;
            while (num > 0)
            {
                var d = num % 10;
                prod *= d;
                s += d;
                num /= 10;
            }

            return n % (s + prod) == 0;
        }
    }
}
