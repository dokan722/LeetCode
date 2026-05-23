using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1752 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 3, 4, 5, 1, 2 };

            var expected = true;

            var result = Check(nums);

            return result == expected;
        }

        public bool Check(int[] nums)
        {
            var n = nums.Length;
            var miss = 0;
            for (int i = 1; i < n; ++i)
            {
                if (nums[i - 1] > nums[i])
                    miss++;
                if (miss >= 2)
                    return false;
            }

            return miss == 0 || nums[n - 1] <= nums[0];
        }
    }
}
