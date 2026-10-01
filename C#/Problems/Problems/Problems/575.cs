using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _575 : IProblem
    {
        public bool Test()
        {
            var candyType = new[] { 1, 1, 2, 2, 3, 3 };

            var expected = 3;

            var result = DistributeCandies(candyType);

            Console.WriteLine(result);

            return result == expected;
        }

        public int DistributeCandies(int[] candyType)
        {
            var n = candyType.Length;
            var types = new HashSet<int>();
            foreach (var c in candyType)
                types.Add(c);
            return Math.Min(n / 2, types.Count);
        }
    }
}
