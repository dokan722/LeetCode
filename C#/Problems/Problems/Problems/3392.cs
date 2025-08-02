using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3392 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 2, 1, 4, 1 };

            var expected = 1;

            var result = CountSubarrays(nums);


            return result == expected;
        }

        public int CountSubarrays(int[] nums)
        {
            var result = 0;
            for (int i = 1; i < nums.Length - 1; ++i)
            {
                if (2 * (nums[i - 1] + nums[i + 1]) == nums[i])
                    result++;
            }

            return result;
        }   
    }
}
