using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1340 : IProblem
    {
        public bool Test()
        {
            var arr = new[] { 6, 4, 14, 6, 8, 13, 9, 7, 10, 6, 12 };
            var d = 2;

            var expected = 4;

            var result = MaxJumps(arr, d);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MaxJumps(int[] arr, int d)
        {
            var n = arr.Length;
            var dp = new int[n];
            var result = 0;
            for (int i = 0; i < n; ++i)
            {
                Dfs(arr, d, i, n, dp);
                result = Math.Max(result, dp[i]);
            }

            return result;
        }

        private void Dfs(int[] arr, int d, int id, int n, int[] dp)
        {
            if (dp[id] != 0)
                return;
            dp[id] = 1;
            for (int i = id - 1; i >= 0 && id - i <= d && arr[i] < arr[id]; --i)
            {
                Dfs(arr, d, i, n, dp);
                dp[id] = Math.Max(dp[id], dp[i] + 1);
            }
            for (int i = id + 1; i < n && i - id <= d && arr[i] < arr[id]; ++i)
            {
                Dfs(arr, d, i, n, dp);
                dp[id] = Math.Max(dp[id], dp[i] + 1);
            }
        }
    }
}
