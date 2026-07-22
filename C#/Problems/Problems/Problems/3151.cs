using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3151 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 2, 1, 4 };

            var expected = true;

            var result = IsArraySpecial(nums);

            return expected == result;
        }

        public bool IsArraySpecial(int[] nums)
        {
            var n = nums.Length;
            for (int i = 0; i < n - 1; ++i)
                if (nums[i] % 2 == nums[i + 1] % 2)
                    return false;

            return true;
        }
    }
}
