using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _55 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 2, 3, 1, 1, 4 };

            var expected = true;

            var result = CanJump(nums);

            return result == expected;
        }

        public bool CanJump(int[] nums)
        {
            var n = nums.Length;
            var mx = 0;
            for (int i = 0; i < n; ++i)
            {
                if (mx < i)
                    return false;
                mx = Math.Max(mx, i + nums[i]);
            }

            return true;
        }
    }
}
