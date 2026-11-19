using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2275 : IProblem
    {
        public bool Test()
        {
            var candidates = new[] { 16, 17, 71, 62, 12, 24, 14 };

            var expected = 4;

            var result = LargestCombination(candidates);

            Console.WriteLine(result);

            return result == expected;
        }

        public int LargestCombination(int[] candidates)
        {
            var result = 0;
            var maxBits = 24;
            for (int i = 0; i < maxBits; ++i)
            {
                var cur = 0;
                var bit = 1 << i;
                foreach (var num in candidates)
                {
                    if ((num & bit) == bit)
                        cur++;
                }
                result = Math.Max(cur, result);
            }

            return result;
        }
    }
}
