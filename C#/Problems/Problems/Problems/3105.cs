using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3105 : IProblem
    {
        public bool Test()
        {
            var nums = new int[] { 1, 4, 3, 3, 2 };

            var expected = 2;

            var result = LongestMonotonicSubarray(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public int LongestMonotonicSubarray(int[] nums)
        {
            var n = nums.Length;
            var result = 1;
            var cur = 1;
            var inc = true;
            for (int i = 1; i < n; ++i)
            {
                if (inc && nums[i] > nums[i - 1])
                    cur++;
                else if (!inc && nums[i] < nums[i - 1])
                    cur++;
                else
                {
                    result = Math.Max(result, cur);
                    inc = !inc;
                    cur = 1 + (nums[i] != nums[i - 1] ? 1 : 0);
                }
            }
            result = Math.Max(result, cur);

            return result;
        }
    }
}
