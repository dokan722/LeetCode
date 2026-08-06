using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3345 : IProblem
    {
        public bool Test()
        {
            var n = 10;
            var t = 2;

            var expected = 10;

            var result = SmallestNumber(n, t);

            Console.WriteLine(result);

            return result == expected;
        }

        public int SmallestNumber(int n, int t)
        {
            for (int i = n; i <= n + 10 * t + 1; ++i)
            {
                var num = i;
                var prod = 1;
                while (num > 0)
                {
                    prod *= num % 10;
                    num /= 10;
                }
                if (prod % t == 0)
                    return i;
            }

            return -1;
        }
    }
}
