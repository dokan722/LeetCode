using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2419 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 2, 3, 3, 2, 2 };

            var expected = 2;

            var result = LongestSubarray(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public int LongestSubarray(int[] nums)
        {
            var n = nums.Length;
            var maxLen = 1;
            var maxNum = nums[0];
            var currLen = 1;

            for (int i = 1; i < n; i++)
            {
                if (nums[i] == nums[i - 1])
                    currLen++;
                else
                {
                    if (nums[i - 1] > maxNum || (nums[i - 1] == maxNum && currLen > maxLen))
                    {
                        maxNum = nums[i - 1];
                        maxLen = currLen;
                    }
                    currLen = 1;
                }
            }
            if (nums[n - 1] > maxNum || (nums[n - 1] == maxNum && currLen > maxLen))
                maxLen = currLen;

            return maxLen;
        }
    }
}
