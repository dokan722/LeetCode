using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2029 : IProblem
    {
        public bool Test()
        {
            var stones = new[] { 2, 1 };

            var expected = true;

            var result = StoneGameIX(stones);

            return expected == result;
        }

        public bool StoneGameIX(int[] stones)
        {
            var counts = new int[3];
            foreach (var stone in stones)
                counts[stone % 3]++;
            if (counts[0] % 2 == 0)
                return counts[1] >= 1 && counts[2] >= 1;
            return Math.Abs(counts[1] - counts[2]) > 2;
        }
    }
}
