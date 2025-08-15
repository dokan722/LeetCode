using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1561 : IProblem
    {
        public bool Test()
        {
            var piles = new[] { 2, 4, 1, 2, 7, 8 };

            var expected = 9;

            var result = MaxCoins(piles);

            Console.WriteLine(result);

            return expected == result;
        }

        public int MaxCoins(int[] piles)
        {
            var n = piles.Length;
            Array.Sort(piles);

            var sum = 0;

            for (int i = 0; i < n / 3; i++)
            {
                sum += piles[n - 2 - 2 * i];
            }

            return sum;
        }
    }
}
