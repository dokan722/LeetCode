using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2952 : IProblem
    {
        public bool Test()
        {
            var coins = new[] { 1, 4, 10 };
            var target = 19;

            var expected = 2;

            var result = MinimumAddedCoins(coins, target);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinimumAddedCoins(int[] coins, int target)
        {
            var n = coins.Length;
            var result = 0;
            var mx = 0;
            Array.Sort(coins);
            var i = 0;
            while (mx < target)
            {
                if (i < n && coins[i] <= mx + 1)
                {
                    mx += coins[i];
                    i++;
                }
                else
                {
                    result++;
                    mx += mx + 1;
                }
            }

            return result;
        }
    }
}
