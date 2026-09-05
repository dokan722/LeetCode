using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _4008 : IProblem
    {
        public bool Test()
        {
            var monsters = new[] { 5, 10, 15 };
            var boosts = new[] { new[] { 1, 1, 10 } };

            var expected = 30;;

            var result = MinInitialStrength(monsters, boosts);

            Console.WriteLine(result);

            return result == expected;
        }

        public long MinInitialStrength(int[] monsters, int[][] boosts)
        {
            var n = monsters.Length;
            var sweep = new long[n + 1];
            foreach (var boost in boosts)
            {
                sweep[boost[0]] += boost[2];
                sweep[boost[1] + 1] -= boost[2];
            }
            long result = 0;
            long curb = 0;
            long acc = 0;
            for (int i = 0; i < n; ++i)
            {
                curb += sweep[i];
                if (curb < monsters[i])
                {
                    result += acc + monsters[i] - curb;
                    acc = curb;
                }
                else
                    acc += monsters[i];
            }
            return result;
        }
    }
}
