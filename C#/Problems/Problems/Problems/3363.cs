using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3363 : IProblem
    {
        public bool Test()
        {
            var fruits = new[] {new[] {1, 2, 3, 4}, new[] {5, 6, 8, 7}, new[] {9, 10, 11, 12}, new[] {13, 14, 15, 16}};

            var expected = 100;

            var result = MaxCollectedFruits(fruits);

            Console.WriteLine(result);

            return expected == result;
        }

        public int MaxCollectedFruits(int[][] fruits)
        {
            var n = fruits.Length;
            var diagonal = 0;
            var dp = new int[n][];
            for (int i = 0; i < n; i++)
            {
                diagonal += fruits[i][i];
                dp[i] = new int[n];
                Array.Fill(dp[i], -1);
            }

            dp[n - 1][n - 1] = 0;
            var lower = CheckLower(fruits, dp, n, n - 1, 0, n - 1);
            var upper = CheckUpper(fruits, dp, n, 0, n - 1, n - 1);


            return diagonal + lower + upper;
        }

        private int CheckLower(int[][] fruits, int[][] dp, int n, int x, int y, int k)
        {
            if (x >= n || (k == 0 && x != y) || (k > 0 && x <= y))
                return -1;
            if (dp[x][y] != -1)
                return dp[x][y];

            var best = Math.Max(Math.Max(CheckLower(fruits, dp, n, x - 1, y + 1, k - 1), CheckLower(fruits, dp, n, x, y + 1, k - 1)),
                CheckLower(fruits, dp, n, x + 1, y + 1, k - 1));

            if (best < 0)
                dp[x][y] = int.MinValue;
            else
                dp[x][y] = fruits[x][y] + best;

            return dp[x][y];
        }

        private int CheckUpper(int[][] fruits, int[][] dp, int n, int x, int y, int k)
        {
            if (y >= n || (k == 0 && x != y) || (k > 0 && x >= y))
                return -1;
            if (dp[x][y] != -1)
                return dp[x][y];

            var best = Math.Max(Math.Max(CheckUpper(fruits, dp, n, x + 1, y - 1, k - 1), CheckUpper(fruits, dp, n, x + 1, y, k - 1)),
                CheckUpper(fruits, dp, n, x + 1, y + 1, k - 1));

            if (best < 0)
                dp[x][y] = int.MinValue;
            else
                dp[x][y] = fruits[x][y] + best;

            return dp[x][y];
        }
    }
}
