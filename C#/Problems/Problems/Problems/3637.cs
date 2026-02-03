using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3637 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 3, 5, 4, 2, 6 };

            var expected = true;

            var result = IsTrionic(nums);

            return result == expected;
        }

        public bool IsTrionic(int[] nums)
        {
            int n = nums.Length;
            if (nums[0] >= nums[1])
            {
                return false;
            }
            int count = 1;
            for (int i = 2; i < n; i++)
            {
                if (nums[i - 1] == nums[i])
                    return false;
                if ((nums[i - 2] - nums[i - 1]) * (nums[i - 1] - nums[i]) < 0)
                {
                    count++;
                }
            }
            return count == 3;
        }
    }
}
