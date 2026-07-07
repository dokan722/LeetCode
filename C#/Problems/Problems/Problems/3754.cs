using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3754 : IProblem
    {
        public bool Test()
        {
            var n = 10203004;

            var expected = 12340;

            var result = SumAndMultiply(n);

            Console.WriteLine(result);

            return result == expected;
        }

        public long SumAndMultiply(int n)
        {
            var x = 0;
            var s = 0;
            var cur = 1;
            while (n > 0)
            {
                var rem = n % 10;
                if (rem != 0)
                {
                    x += rem * cur;
                    s += rem;
                    cur *= 10;
                }
                n /= 10;
            }

            return (long)x * s;
        }
    }
}
