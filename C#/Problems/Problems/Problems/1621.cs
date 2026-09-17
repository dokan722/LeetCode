using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1621 : IProblem
    {
        public bool Test()
        {
            var n = 4;
            var k = 2;

            var expected = 5;

            var result = NumberOfSets(n, k);

            Console.WriteLine(result);

            return result == expected;
        }

        public int NumberOfSets(int n, int k)
        {
            if (k == 1)
                return n * (n - 1) / 2;
            var mod = 1000000007;
            var dp = new int[n]; ;
            var pref = new int[n + 1];
            for (int i = 0; i < n; ++i)
            {
                dp[i] = 1;
                pref[i + 1] = i + 1;
            }
            for (int i = 1; i <= k; ++i)
            {
                dp[0] = 0;
                for (int j = 1; j < n; ++j)
                    dp[j] = (dp[j - 1] + pref[j]) % mod;
                for (int j = 0; j < n; ++j)
                    pref[j + 1] = (pref[j] + dp[j]) % mod;
            }

            return dp[n - 1];
        }
    }
}
