using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1039 : IProblem
    {
        public bool Test()
        {
            var values = new[] { 1, 3, 1, 4, 1, 5 };

            var expected = 13;

            var result = MinScoreTriangulation(values);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinScoreTriangulation(int[] values)
        {
            var n = values.Length;
            var dp = new int[n][];
            for (int i = 0; i < n; ++i)
                dp[i] = Enumerable.Repeat(-1, n).ToArray();
            return MinScoreRec(0, n - 1, values, dp);
        }

        private int MinScoreRec(int left, int right, int[] values, int[][] dp)
        {
            if (left > right - 2)
                return 0;
            if (dp[left][right] == -1)
            {
                var minScore = int.MaxValue;
                for (int i = left + 1; i < right; ++i)
                {
                    minScore = Math.Min(minScore,
                        MinScoreRec(left, i, values, dp) + values[left] * values[right] * values[i] +
                        MinScoreRec(i, right, values, dp));
                }
                dp[left][right] = minScore;
            }

            return dp[left][right];
        }
    }
}
