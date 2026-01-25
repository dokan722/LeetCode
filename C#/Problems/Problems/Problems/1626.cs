using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1626 : IProblem
    {
        public bool Test()
        {
            var scores = new[] { 1, 3, 5, 10, 15 };
            var ages = new[] { 1, 2, 3, 4, 5 };

            var expected = 34;

            var result = BestTeamScore(scores, ages);

            Console.WriteLine(result);

            return result == expected;
        }

        public int BestTeamScore(int[] scores, int[] ages)
        {
            var playersNumber = scores.Length;
            var maxAge = 1000;
            var sortedPairs = scores.Zip(ages).OrderBy(x => x).ToArray();
            var dp = new int[maxAge + 1];
            for (int i = 0; i < playersNumber; ++i)
            {
                var currMax = sortedPairs[i].Item1;
                for (int j = 0; j <= sortedPairs[i].Item2; ++j)
                    currMax = Math.Max(currMax, dp[j] + sortedPairs[i].Item1);
                dp[sortedPairs[i].Item2] = currMax;
            }
            var maxScore = 0;
            for (int i = 0; i <= maxAge; ++i)
                maxScore = Math.Max(maxScore, dp[i]);
            return maxScore;
        }
    }
}
