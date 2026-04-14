using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2463 : IProblem
    {
        public bool Test()
        {
            var robot = new[] {0, 4, 6};
            var factory = new[] { new[] { 2, 2 }, new[] { 6, 2 } };

            var expected = 4;

            var result = MinimumTotalDistance(robot, factory);

            Console.WriteLine(result);

            return result == expected;
        }

        public long MinimumTotalDistance(IList<int> robot, int[][] factory)
        {
            robot = robot.OrderBy(x => x).ToArray();
            Array.Sort(factory, (x, y) => x[0].CompareTo(y[0]));
            var n = robot.Count;
            var m = factory.Length;

            var dp = new long[n + 1][];
            for (int i = 0; i <= n; ++i)
                dp[i] = Enumerable.Repeat(long.MaxValue / (m + 1), m + 1).ToArray();
            for (int i = 0; i <= m; ++i)
                dp[0][i] = 0;

            for (int i = 1; i <= n; ++i)
            {
                for (int j = 1; j <= m; ++j)
                {
                    dp[i][j] = dp[i][j - 1];
                    var newPos = factory[j - 1][0];
                    var newCap = factory[j - 1][1];
                    long acmDist = 0;
                    for (int k = 1; k <= newCap && k <= i; ++k)
                    {
                        acmDist += Math.Abs((long)newPos - robot[i - k]);
                        dp[i][j] = Math.Min(dp[i][j], acmDist + dp[i - k][j - 1]);
                    }
                }
            }
            return dp[n][m];
        }
    }
}
