using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _948 : IProblem
    {
        public bool Test()
        {
            var tokens = new[] { 100, 200, 300, 400 };
            var power = 200;

            var expected = 2;

            var result = BagOfTokensScore(tokens, power);

            Console.WriteLine(result);

            return result == expected;
        }

        public int BagOfTokensScore(int[] tokens, int power)
        {
            var n = tokens.Length;
            Array.Sort(tokens);
            var l = 0;
            var r = n - 1;
            var score = 0;
            while (l < r)
            {
                if (tokens[l] <= power)
                {
                    score++;
                    power -= tokens[l];
                    l++;
                }
                else if (score > 0)
                {
                    score--;
                    power += tokens[r];
                    r--;
                }
                else
                    break;
            }
            if (l == r && tokens[l] <= power)
                score++;
            return score;
        }
    }
}
