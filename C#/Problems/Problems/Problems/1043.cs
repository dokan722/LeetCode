using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1043 : IProblem
    {
        public bool Test()
        {
            var arr = new[] { 1, 15, 7, 9, 2, 5, 10 };
            var k = 3;

            var expected = 84;

            var result = MaxSumAfterPartitioning(arr, k);

            Console.WriteLine(result);

            return result == expected;
        }
        public int MaxSumAfterPartitioning(int[] arr, int k)
        {
            var n = arr.Length;
            var dp = new int[n];
            var m = arr[0];
            for (int i = 0; i < k; ++i)
            {
                m = Math.Max(m, arr[i]);
                dp[i] = (i + 1) * m;
            }
            for (int i = k; i < n; ++i)
            {
                m = arr[i];
                var curr = arr[i];
                var best = curr + dp[i - 1];
                for (int j = 1; j < k; ++j)
                {
                    if (m < arr[i - j])
                    {
                        curr += j * (arr[i - j] - m);
                        m = arr[i - j];
                    }

                    curr += m;
                    best = Math.Max(best, dp[i - j - 1] + curr);
                }

                dp[i] = best;
            }

            return dp[n - 1];
        }

    }
}
