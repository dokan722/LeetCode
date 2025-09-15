using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1833 : IProblem
    {
        public bool Test()
        {
            var costs = new[] { 1, 3, 2, 4, 1 };
            var coins = 7;

            var expected = 4;

            var result = MaxIceCream(costs, coins);

            Console.WriteLine(result);

            return expected == result;
        }

        public int MaxIceCream(int[] costs, int coins)
        {
            Array.Sort(costs);

            var i = 0;
            while (i < costs.Length && costs[i] <= coins)
            {
                coins -= costs[i];
                i++;
            }

            return i;
        }
    }
}
