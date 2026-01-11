using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _712 : IProblem
    {
        public bool Test()
        {
            var s1 = "delete";
            var s2 = "leet";

            var expected = 403;

            var result = MinimumDeleteSum(s1, s2);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinimumDeleteSum(string s1, string s2)
        {
            var n = s1.Length;
            var m = s2.Length;
            var dp = new int[n + 1][];
            for (int i = 0; i <= n; ++i)
                dp[i] = new int[m + 1];
            for (int i = 1; i <= n; ++i)
                dp[i][0] = dp[i - 1][0] + s1[i - 1];
            for (int i = 1; i <= m; ++i)
                dp[0][i] = dp[0][i - 1] + s2[i - 1];


            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    var addBoth = dp[i][j] + (s1[i] == s2[j] ? 0 : s1[i] + s2[j]);
                    var addFirst = dp[i][j + 1] + s1[i];
                    var addSecond = dp[i + 1][j] + s2[j];
                    dp[i + 1][j + 1] = Math.Min(addBoth, Math.Min(addFirst, addSecond));
                }
            }

            return dp[n][m];
        }
    }
}
