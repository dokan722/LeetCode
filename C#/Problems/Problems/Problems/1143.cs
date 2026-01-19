using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1143 : IProblem
    {
        public bool Test()
        {
            var text1 = "abcde";
            var text2 = "ace";

            var expected = 3;

            var result = LongestCommonSubsequence(text1, text2);

            Console.WriteLine(result);

            return result == expected;
        }

        public int LongestCommonSubsequence(string text1, string text2)
        {
            var n = text1.Length;
            var m = text2.Length;
            var dp = new int[n + 1][];
            for (int i = 0; i <= n; ++i)
                dp[i] = new int[m + 1];
            for (int i = 1; i <= n; ++i)
            {
                for (int j = 1; j <= m; ++j)
                {
                    dp[i][j] = Math.Max(dp[i - 1][j - 1] + (text1[i - 1] == text2[j - 1] ? 1 : 0), Math.Max(dp[i - 1][j], dp[i][j - 1]));
                }
            }

            return dp[n][m];
        }
    }
}
