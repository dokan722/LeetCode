using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2006 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 3, 2, 1, 5, 4 };
            var k = 2;

            var expected = 3;

            var result = CountKDifference(nums, k);

            Console.WriteLine(result);

            return expected == result;
        }

        public int CountKDifference(int[] nums, int k)
        {
            var n = nums.Length;
            var counts = new int[100 + 2 * k + 1];
            int result = 0;
            for (int i = 0; i < n; i++)
            {
                result += counts[nums[i]] + counts[nums[i] + 2 * k];
                counts[nums[i] + k]++;
            }
            return result;
        }
    }
}
