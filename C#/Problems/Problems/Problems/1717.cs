using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1717 : IProblem
    {
        public bool Test()
        {
            var s = "cdbcbbaaabab";
            var x = 4;
            var y = 5;

            var expected = 19;

            var result = MaximumGain(s, x, y);

            Console.WriteLine(result);

            return expected == result;
        }

        public int MaximumGain(string s, int x, int y)
        {
            var betterReward = Math.Max(x, y);
            var worseReward = Math.Min(x, y);
            var betterLetter = x > y ? 'a' : 'b';
            var worseLetter = x > y ? 'b' : 'a';
            var betterCount = 0;
            var worseCount = 0;
            var score = 0;

            foreach (var c in s)
            {
                if (c == betterLetter)
                {
                    betterCount++;
                }
                else if (c == worseLetter)
                {
                    if (betterCount > 0)
                    {
                        betterCount--;
                        score += betterReward;
                    }
                    else
                        worseCount++;

                }
                else
                {
                    score += Math.Min(betterCount, worseCount) * worseReward;
                    betterCount = 0;
                    worseCount = 0;
                }
            }

            score += Math.Min(betterCount, worseCount) * worseReward;

            return score;
        }
    }
}
