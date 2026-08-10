using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1510 : IProblem
    {
        public bool Test()
        {
            var n = 4;

            var expected = true;

            var result = WinnerSquareGame(n);

            return expected == result;
        }

        public bool WinnerSquareGame(int n)
        {
            var dp = Enumerable.Repeat(-1, n + 1).ToArray();
            return CanWin(dp, n);
        }

        private bool CanWin(int[] dp, int n)
        {
            if (n <= 0)
                return false;
            if (dp[n] != -1)
                return dp[n] == 1;
            var limit = Math.Sqrt(n + 1);
            var res = 0;
            for (int i = 1; i < limit; ++i)
            {
                if (!CanWin(dp, n - i * i))
                {
                    res = 1;
                    break;
                }
            }
            dp[n] = res;
            return res == 1;
        }
    }
}
