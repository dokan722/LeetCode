using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _650 : IProblem
    {
        public bool Test()
        {
            var n = 3;

            var expected = 3;

            var result = MinSteps(n);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinSteps(int n)
        {
            var dp = new int[n + 1];
            Array.Fill(dp, int.MaxValue);
            dp[1] = 0;
            for (int i = 2; i <= n; ++i)
            {
                for (int j = 1; j <= i / 2; j++)
                {
                    if (i % j == 0)
                        dp[i] = Math.Min(dp[i], dp[j] + i / j);
                }
            }

            return dp[n];
        }
    }
}
