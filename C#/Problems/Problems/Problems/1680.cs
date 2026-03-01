using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1680 : IProblem
    {
        public bool Test()
        {
            var n = 12;

            var expected = 505379714;

            var result = ConcatenatedBinary(n);

            Console.WriteLine(result);

            return result == expected;
        }

        public int ConcatenatedBinary(int n)
        {
            var currPow = 2;
            long result = 0;
            var mod = 1000000007;
            for (int i = 1; i <= n; ++i)
            {
                if (currPow == i)
                    currPow *= 2;
                result = (result * currPow + i) % mod;
            }

            return (int)result;
        }
    }
}
