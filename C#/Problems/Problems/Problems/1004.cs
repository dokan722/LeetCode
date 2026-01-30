using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1004 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0 };

            var k = 2;

            var expected = 6;

            var result = LongestOnes(nums, k);

            Console.WriteLine(result);

            return expected == result;
        }

        public int LongestOnes(int[] nums, int k)
        {
            var n = nums.Length;
            var left = 0;
            var zeros = 0;
            var result = 0;
            for (int i = 0; i < n; ++i)
            {
                if (nums[i] == 0)
                    zeros++;
                while (zeros > k && left <= i)
                {
                    if (nums[left] == 0)
                        zeros--;
                    left++;
                }
                result = Math.Max(result, i - left + 1);
            }

            return result;
        }
    }
}
