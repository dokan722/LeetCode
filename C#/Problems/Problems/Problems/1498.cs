using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1498 : IProblem
    {
        public bool Test()
        {
            var nums = new int[] {2, 3, 3, 4, 6, 7};
            var target = 12;

            var expected = 61;

            var result = NumSubseq(nums, target);

            Console.WriteLine(result);

            return expected == result;
        }

        public int NumSubseq(int[] nums, int target)
        {
            Array.Sort(nums);
            var powers = new int[nums.Length];
            var mod = (int)(Math.Pow(10, 9) + 7);
            powers[0] = 1;
            for (int i = 1; i < nums.Length; i++)
                powers[i] = powers[i - 1] * 2 % mod;
            var result = 0;
            var left = 0;
            var right = nums.Length - 1;
            while (left <= right)
            {
                if (nums[left] + nums[right] <= target)
                {
                    result = (result + powers[right - left]) % mod;
                    left++;
                }
                else
                    right--;

            }
            return result;
        }
    }
}
