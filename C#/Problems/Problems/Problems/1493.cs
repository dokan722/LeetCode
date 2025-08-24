using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1493 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 0, 1, 1, 1, 0, 1, 1, 0, 1 };
            var expected = 5;

            var result = LongestSubarray(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public int LongestSubarray(int[] nums)
        {
            var result = 0;
            var j = 0;
            var zeros = 0;
            var ones = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                    zeros++;
                else
                    ones++;
                while (j < i && zeros > 1)
                {
                    if (nums[j] == 0)
                        zeros--;
                    else
                        ones--;
                    j++;
                }

                var sub = zeros == 0 ? 1 : 0;
                if (ones - sub > result)
                    result = ones - sub;
            }

            return result;
        }
    }
}
