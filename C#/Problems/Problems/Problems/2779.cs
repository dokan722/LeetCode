using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2779 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 4, 6, 1, 2 };
            var k = 2;

            var expected = 3;

            var result = MaximumBeauty(nums, k);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MaximumBeauty(int[] nums, int k)
        {
            int maxValue = 0;
            foreach (var num in nums)
            {
                maxValue = Math.Max(maxValue, num);
            }
            var range = maxValue + 2 * (k + 1);
            var intervals = new int[range];

            foreach (var num in nums)
            {
                intervals[num]++;
                intervals[num + 2 * k + 1]--;
            }

            int inside = 0;
            int result = 0;

            for (int i = 0; i < range; i++)
            {
                if (intervals[i] != 0)
                {
                    inside += intervals[i];
                    result = Math.Max(result, inside);
                }
            }

            return result;
        }
    }
}
