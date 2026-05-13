using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1674 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 2, 4, 3 };
            var limit = 4;

            var expected = 1;

            var result = MinMoves(nums, limit);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinMoves(int[] nums, int limit)
        {
            var counts = new int[2 * limit + 1];
            var ranges = new int[2 * limit + 2];
            var n = nums.Length;
            var l = n / 2;
            for (int i = 0; i < l; ++i)
            {
                var sum = nums[i] + nums[n - 1 - i];
                var left = Math.Min(nums[i] + 1, nums[n - 1 - i] + 1);
                var right = Math.Max(limit + nums[i], limit + nums[n - 1 - i]);
                counts[sum]++;
                ranges[left]++;
                ranges[right + 1]--;
            }

            var result = int.MaxValue;
            var inRange = 0;
            for (int i = 0; i <= 2 * limit; ++i)
            {
                inRange += ranges[i];
                var mvs = l * 2 - inRange - counts[i];
                result = Math.Min(result, mvs);
            }

            return result;
        }
    }
}
