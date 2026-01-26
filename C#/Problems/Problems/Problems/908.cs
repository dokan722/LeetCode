using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _908 : IProblem
    {
        public bool Test()
        {
            var nums = new[] {1, 3, 6 };
            var k = 3;

            var expected = 0;

            var result = SmallestRangeI(nums, k);

            Console.WriteLine(result);

            return result == expected;
        }

        public int SmallestRangeI(int[] nums, int k)
        {
            int maxValue = nums[0], minValue = nums[0];
            for (int i = 1; i < nums.Length; ++i)
            {
                maxValue = Math.Max(maxValue, nums[i]);
                minValue = Math.Min(minValue, nums[i]);
            }
            return Math.Max(0, maxValue - minValue - 2 * k);
        }
    }
}
