using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2327 : IProblem
    {
        public bool Test()
        {
            var n = 6;
            var delay = 2;
            var forget = 4;

            var expected = 5;

            var result = PeopleAwareOfSecret(n, delay, forget);

            Console.WriteLine(result);

            return result == expected;
        }

        public int PeopleAwareOfSecret(int n, int delay, int forget)
        {
            var dp = new long[n];
            dp[0] = 1;
            long share = 0;
            var mod = 1000000007;
            for (int i = 1; i < n; i++)
            {
                if (i - delay >= 0)
                    share = (share + dp[i - delay] + mod) % mod;
                if (i - forget >= 0)
                    share = (share - dp[i - forget] + mod) % mod;
                dp[i] = share;
            }

            long know = 0;

            for (int i = n - forget; i < n; i++)
                know = (know + dp[i]) % mod;

            return (int)know;
        }
    }
}
