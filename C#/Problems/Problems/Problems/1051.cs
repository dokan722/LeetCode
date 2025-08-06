using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1051 : IProblem
    {
        public bool Test()
        {
            var heights = new[] { 1, 1, 4, 2, 1, 3 };

            var expected = 3;

            var result = HeightChecker(heights);

            Console.WriteLine(result);

            return expected == result;
        }

        public int HeightChecker(int[] heights)
        {
            var sorted = (int[])heights.Clone();
            Array.Sort(sorted);
            var result = 0;
            for (int i = 0; i < heights.Length; i++)
            {
                if (heights[i] != sorted[i])
                    result++;
            }

            return result;
        }
    }
}
