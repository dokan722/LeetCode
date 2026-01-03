using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1411 : IProblem
    {
        public bool Test()
        {
            var n = 5000;

            var expected = 30228214;

            var result = NumOfWays(n);

            Console.WriteLine(result);

            return result == expected;
        }

        public int NumOfWays(int n)
        {
            var mod = 1000000007;
            long two = 6;
            long three = 6;

            for (int i = 1; i < n; i++)
            {
                long nextTwo = (3 * two + 2 * three) % mod;
                long nextThree = (2 * two + 2 * three) % mod;
                two = nextTwo;
                three = nextThree;
            }

            return (int)((two + three) % mod);
        }
    }
}
