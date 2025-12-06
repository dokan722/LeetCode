using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1470 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 2, 5, 1, 3, 4, 7 };
            var n = 3;

            var expected = new[] { 2, 3, 5, 4, 1, 7 };

            var result = Shuffle(nums, n);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }

        public int[] Shuffle(int[] nums, int n)
        {
            var result = new int[2*n];
            for (int i = 0; i < n; ++i)
            {
                result[2 * i] = nums[i];
                result[2 * i + 1] = nums[n + i];
            }

            return result;
        }
    }
}
