using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _775 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 0, 2 };

            var expected = true;

            var result = IsIdealPermutation(nums);

            return expected == result;
        }

        public bool IsIdealPermutation(int[] nums)
        {
            var n = nums.Length;
            for (int i = 0; i < n; ++i)
            {
                if (Math.Abs(nums[i] - i) > 1)
                    return false;
            }

            return true;
        }
    }
}
