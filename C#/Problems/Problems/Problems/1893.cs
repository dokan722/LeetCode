using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1893 : IProblem
    {
        public bool Test()
        {
            var ranges = new int[][] { new int[] { 1, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 } };

            var left = 2;
            var right = 5;
            var expected = true;

            var result = IsCovered(ranges, left, right);

            Console.WriteLine(result);

            return result == expected;
        }

        public bool IsCovered(int[][] ranges, int left, int right)
        {
            var covered = new bool[50];
            foreach (var range in ranges)
            {
                for (int i = range[0] - 1; i <= range[1] - 1; i++)
                    covered[i] = true;
            }

            for (int i = left - 1; i <= right - 1; ++i)
            {
                if (!covered[i])
                    return false;
            }

            return true;
        }
    }
}
