using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2550 : IProblem
    {
        public bool Test()
        {
            var n = 3;

            var expected = 6;

            var result = MonkeyMove(n);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MonkeyMove(int n)
        {
            long result = 1;
            long b = 2;
            var mod = 1000000007;
            while (n > 0)
            {
                if (n % 2 == 1)
                    result = result * b % mod;
                b = b * b % mod;
                n /= 2;
            }

            return (int)(result - 2 + mod) % mod;
        }
    }
}
