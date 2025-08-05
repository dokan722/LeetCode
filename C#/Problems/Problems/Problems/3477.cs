using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3477 : IProblem
    {
        public bool Test()
        {
            var fruits = new[] { 3, 6, 1 };
            var baskets = new[] { 6, 4, 7 };

            var expected = 0;

            var result = NumOfUnplacedFruits(fruits, baskets);

            Console.WriteLine(result);

            return result == expected;
        }

        public int NumOfUnplacedFruits(int[] fruits, int[] baskets)
        {
            var n = fruits.Length;
            var result = 0;
            foreach (var fruit in fruits)
            {
                var bs = 0;
                while (bs < n && baskets[bs] < fruit)
                    bs++;
                if (bs == n)
                    continue;
                baskets[bs] = 0;
                result++;
            }

            return n - result;
        }
    }
}
