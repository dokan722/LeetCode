using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3592 : IProblem
    {
        public bool Test()
        {
            var numWays = new[] { 0, 1, 0, 2, 0, 3, 0, 4, 0, 5 };

            var expected = new[] { 2, 4, 6 };

            var result = FindCoins(numWays).ToArray();

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(result, expected);
        }

        public IList<int> FindCoins(int[] numWays)
        {
            var n = numWays.Length;
            var dp = new int[n + 1];
            dp[0] = 1;
            var result = new List<int>();
            for (int i = 1; i <= n; ++i)
            {
                if (dp[i] != numWays[i - 1])
                {
                    if (numWays[i - 1] - dp[i] != 1)
                        return new List<int>();
                    dp[i]++;
                    for (int j = i + 1; j <= n; ++j)
                    {
                        dp[j] += dp[j - i];
                    }
                    result.Add(i);
                }
            }

            return result;
        }
    }
}
