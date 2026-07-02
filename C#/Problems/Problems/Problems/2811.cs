using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2811 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 2, 2, 1 };
            var m = 4;

            var expected = true;

            var result = CanSplitArray(nums, m);

            return result == expected;
        }

        public bool CanSplitArray(IList<int> nums, int m)
        {
            var n = nums.Count;
            if (n < 3)
                return true;
            for (int i = 1; i < n; ++i)
            {
                if (nums[i - 1] + nums[i] >= m)
                    return true;
            }

            return false;
        }
    }
}
