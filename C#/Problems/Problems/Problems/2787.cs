using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2787 : IProblem
    {
        public bool Test()
        {
            var n = 64;
            var x = 3;

            var expected = 1;

            var result = NumberOfWays(n, x);

            Console.WriteLine(result);

            return result == expected;
        }

        public int NumberOfWays(int n, int x)
        {
            var mod = 1000000007;
            var poss = new int[n + 1];
            poss[0] = 1;
            for (int i = 1; i <= n; i++)
            {
                int val = (int)Math.Pow(i, x);
                if (val > n)
                    break;
                for (int j = n; j >= val; j--)
                    poss[j] = (poss[j] + poss[j - val]) % mod;
            }
            return poss[n];
        }
    }
}
