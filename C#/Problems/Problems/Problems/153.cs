using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _153 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 3, 4, 5, 1, 2 };

            var expected = 1;

            var result = FindMin(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public int FindMin(int[] nums)
        {
            var n = nums.Length;
            if (nums[0] < nums[n - 1])
                return nums[0];
            var left = 0;
            var right = n - 1;
            while (left < right)
            {
                var mid = (left + right + 1) / 2;
                if (nums[mid] < nums[right])
                    right = mid;
                else
                    left = mid;
            }

            return nums[left];
        }
    }
}
