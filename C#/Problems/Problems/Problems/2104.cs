using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2104 : IProblem
    {
        public bool Test()
        {
            var nums = new[] {4, -2, -3, 4, 1};

            long expected = 59;

            var result = SubArrayRanges(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public long SubArrayRanges(int[] nums)
        {
            var n = nums.Length;
            long result = 0;
            for (int i = 0; i < n; i++)
            {
                var currMin = nums[i];
                var currMax = nums[i];
                for (int j = i + 1; j < n; j++)
                {
                    currMin = Math.Min(currMin, nums[j]);
                    currMax = Math.Max(currMax, nums[j]);
                    result += currMax - currMin;
                }
            }

            return result;
        }
    }
}
