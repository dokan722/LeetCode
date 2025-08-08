using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _808 : IProblem
    {
        public bool Test()
        {
            var n = 100;

            var expected = 0.71875;

            var result = SoupServings(n);

            Console.WriteLine(result);

            return Math.Abs(result - expected) < 1e-5;
        }

        public double SoupServings(int n)
        {
            var s = (int)Math.Ceiling(n / 25.0);
            if (s >= 200)
                return 1;
            var dp = new double[s + 1][];
            for (int i = 0; i <= s; i++)
            {
                dp[i] = new double[s + 1];
                Array.Fill(dp[i], -1);
            }

            return GetProb(dp, s, s);
        }

        private double GetProb(double[][] dp, int a, int b)
        {
            if (a <= 0 && b <= 0)
                return 0.5;
            if (a <= 0)
                return 1;
            if (b <= 0)
                return 0;
            if (dp[a][b] < 0)
                dp[a][b] = 0.25 * (GetProb(dp, a - 4, b) + GetProb(dp, a - 3, b - 1) + GetProb(dp, a - 2, b - 2) + GetProb(dp, a - 1, b - 3));
            return dp[a][b];
        }
    }
}
