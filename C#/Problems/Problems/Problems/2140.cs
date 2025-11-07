using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2140 : IProblem
    {
        public bool Test()
        {
            var questions = new[] { new[] {21,5}, new[] { 92,3}, new[] { 74,2}, new[] { 39,4}, new[] { 58,2}, new[] { 5,5}, new[] { 49,4},new[] {65,3} };

            var expected = 157;

            var result = MostPoints(questions);

            Console.WriteLine(result);

            return result == expected;
        }

        public long MostPoints(int[][] questions)
        {
            var n = questions.Length;
            long result = 0;
            long bestPrev = 0;
            var dp = new long[n];
            for (int i = 0; i < n; ++i)
            {
                var question = questions[i];
                bestPrev = Math.Max(bestPrev, dp[i]);
                var curr = bestPrev + question[0];
                result = Math.Max(curr, result);
                var next = i + question[1] + 1;
                if (next < n)
                    dp[next] = Math.Max(curr, dp[next]);
            }

            return result;
        }
    }
}
