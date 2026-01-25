using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1984 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 9, 4, 1, 7 };
            var k = 2;

            var expected = 2;

            var result = MinimumDifference(nums, k);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinimumDifference(int[] nums, int k)
        {
            Array.Sort(nums);
            var minDiff = int.MaxValue; ;
            for (int i = k - 1; i < nums.Length; ++i)
            {
                minDiff = Math.Min(minDiff, nums[i] - nums[i - k + 1]);
            }

            return minDiff;
        }
    }
}
