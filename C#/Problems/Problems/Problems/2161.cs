using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2161 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 9, 12, 5, 10, 14, 3, 10 };
            var pivot = 10;

            var expected = new[] { 9, 5, 3, 10, 10, 12, 14 };

            var result = PivotArray(nums, pivot);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }

        public int[] PivotArray(int[] nums, int pivot)
        {
            var n = nums.Length;
            var result = new int[n];
            var lp = 0;
            var rp = n - 1;
            for (int i = 0; i < n; ++i)
            {
                var left = nums[i];
                var right = nums[n - 1 - i];
                if (left < pivot)
                    result[lp++] = left;
                if (right > pivot)
                    result[rp--] = right;
            }
            for (int i = lp; i <= rp; ++i)
                result[i] = pivot;

            return result;
        }
    }
}
