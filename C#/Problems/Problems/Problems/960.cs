using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _960 : IProblem
    {
        public bool Test()
        {
            var strs = new[] { "babca", "bbazb" };

            var expected = 3;

            var result = MinDeletionSize(strs);

            Console.WriteLine(result);

            return result == expected;
        }
        public int MinDeletionSize(string[] strs)
        {
            var n = strs.Length;
            var m = strs[0].Length;
            var dp = Enumerable.Repeat(1, m).ToArray();
            for (int i = 0; i < m; ++i)
            {
                for (int j = 0; j < i; ++j)
                {
                    var sorted = true;
                    for (int k = 0; k < n; ++k)
                    {
                        if (strs[k][i] < strs[k][j])
                        {
                            sorted = false;
                            break;
                        }
                    }

                    if (sorted)
                        dp[i] = Math.Max(dp[i], dp[j] + 1);

                }
            }

            var result = 0;
            for (int i = 0; i < m; ++i)
                result = Math.Max(result, dp[i]);

            return m - result;
        }

    }
}
