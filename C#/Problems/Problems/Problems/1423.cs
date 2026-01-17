using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1423 : IProblem
    {
        public bool Test()
        {
            var cardPoints = new[] { 1, 2, 3, 4, 5, 6, 1 };
            var k = 3;

            var expected = 12;

            var result = MaxScore(cardPoints, k);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MaxScore(int[] cardPoints, int k)
        {
            var n = cardPoints.Length;
            var curr = 0;
            for (int i = 0; i < k; ++i)
                curr += cardPoints[i];
            var result = curr;
            for (int i = 0; i < k; ++i)
            {
                curr += cardPoints[n - 1 - i] - cardPoints[k - 1 - i];
                result = Math.Max(result, curr);
            }

            return result;
        }
    }
}
