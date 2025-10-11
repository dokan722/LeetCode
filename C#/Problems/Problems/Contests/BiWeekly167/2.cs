using Problems.Problems;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Contests.BiWeekly167
{
    public class _2 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 1, 1, 1, 2, 3, 5, 1 };
            var expected = 5;

            var result = LongestSubarray(nums);

            Console.WriteLine(result);

            return expected == result;
        }

        public int LongestSubarray(int[] nums)
        {
            var n = nums.Length;
            var begin = 0;
            var result = 2;
            for (int i = 2; i < n; ++i)
            {
                if (nums[i - 1] + nums[i - 2] == nums[i])
                    continue;
                result = Math.Max(result, i - begin);
                begin = i - 1;
            }
            result = Math.Max(result, n - begin);

            return result;
        }
    }
}
