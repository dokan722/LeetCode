using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1798 : IProblem
    {
        public bool Test()
        {
            var coins = new[] { 1, 3 };

            var expected = 2;

            var result = GetMaximumConsecutive(coins);

            Console.WriteLine(result);

            return result == expected;
        }

        public int GetMaximumConsecutive(int[] coins)
        {
            Array.Sort(coins);
            var result = 1;
            foreach (var c in coins)
            {
                if (result < c)
                    break;
                result += c;
            }

            return result;
        }
    }
}
