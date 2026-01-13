using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2466 : IProblem
    {
        public bool Test()
        {
            var low = 2;
            var high = 3;
            var zero = 1;
            var one = 2;

            var expected = 5;

            var result = CountGoodStrings(low, high, zero, one);

            Console.WriteLine(result);

            return result == expected;
        }

        public int CountGoodStrings(int low, int high, int zero, int one)
        {
            var dp = new int[high + 1];
            dp[0] = 1;
            var big = Math.Max(zero, one);
            var smal = Math.Min(zero, one);
            var mod = 1000000007;
            var result = 0;
            for (int i = smal; i <= high; ++i)
            {
                dp[i] += dp[i - smal] % mod;
                if (i >= big)
                    dp[i] += dp[i - big] % mod;
                if (i >= low)
                {
                    result = (result + dp[i]) % mod;
                }
            }

            return result;
        }
    }
}
