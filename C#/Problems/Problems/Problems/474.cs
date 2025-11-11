using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _474 : IProblem
    {
        public bool Test()
        {
            var strs = new[] { "10", "0001", "111001", "1", "0" };
            var m = 5;
            var n = 3;

            var expected = 4;

            var result = FindMaxForm(strs, m, n);

            Console.WriteLine(result);

            return result == expected;
        }

        public int FindMaxForm(string[] strs, int m, int n)
        {
            var dp = new int[m + 1][];
            for (int i = 0; i <= m; ++i)
                dp[i] = new int[n + 1];

            foreach (var str in strs)
            {
                var zeros = 0;
                foreach (var c in str)
                {
                    if (c == '0')
                        zeros++;
                }
                var ones = str.Length - zeros;
                for (int i = m; i >= zeros; --i)
                {
                    for (int j = n; j >= ones; --j)
                    {
                        dp[i][j] = Math.Max(dp[i][j], dp[i - zeros][j - ones] + 1);
                    }
                }
            }

            var result = 0;
            for (int i = 0; i <= m; ++i)
                for (int j = 0; j <= n; ++j)
                    result = Math.Max(result, dp[i][j]);

            return result;
        }
    }
}
