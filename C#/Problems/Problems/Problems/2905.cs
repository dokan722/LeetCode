using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2905 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 5, 1, 4, 1 };
            var indexDifference = 2;
            var valueDifference = 4;

            var expected = new[] { 0, 3 };

            var result = FindIndices(nums, indexDifference, valueDifference);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }

        public int[] FindIndices(int[] nums, int indexDifference, int valueDifference)
        {
            var n = nums.Length;
            var mx = 0;
            var mn = 0;
            for (int i = indexDifference; i < n; ++i)
            {
                var id = i - indexDifference;
                if (nums[mx] < nums[id])
                    mx = id;
                else if (nums[mn] > nums[id])
                    mn = id;
                if (Math.Abs(nums[i] - nums[mx]) >= valueDifference)
                    return new[] { mx, i };
                if (Math.Abs(nums[i] - nums[mn]) >= valueDifference)
                    return new[] { mn, i };
            }

            return new int[] { -1, -1 };
        }
    }
}
