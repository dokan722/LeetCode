using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1406 : IProblem
    {
        public bool Test()
        {
            var stoneValue = new[] { 1, 2, 3, 7 };

            var expected = "Bob";

            var result = StoneGameIII(stoneValue);

            Console.WriteLine(result);

            return result == expected;
        }

        public string StoneGameIII(int[] stoneValue)
        {
            var n = stoneValue.Length;
            var a = "Alice";
            var b = "Bob";
            var t = "Tie";
            var dp = new int[n + 1];
            for (int i = n - 1; i >= 0; --i)
            {
                var best = int.MinValue;
                var s = 0;
                for (int k = 1; k <= 3; k++)
                {
                    if (i + k > n)
                        break;
                    s += stoneValue[i + k - 1];
                    best = Math.Max(best, s - dp[i + k]);
                }
                dp[i] = best;
            }
            if (dp[0] > 0)
                return a;
            if (dp[0] < 0)
                return b;
            return t;
        }
    }
}
