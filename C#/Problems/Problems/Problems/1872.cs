using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1872 : IProblem
    {
        public bool Test()
        {
            var stones = new[] { -1, 2, -3, 4, -5 };

            var expected = 5;

            var result = StoneGameVIII(stones);

            Console.WriteLine(result);

            return result == expected;
        }

        public int StoneGameVIII(int[] stones)
        {
            var n = stones.Length;
            var pref = new int[n];
            pref[0] = stones[0];
            for (int i = 1; i < n; ++i)
                pref[i] = pref[i - 1] + stones[i];
            var result = pref[n - 1];
            for (int i = n - 2; i > 0; --i)
                result = Math.Max(result, pref[i] - result);

            return result;
        }
    }
}
