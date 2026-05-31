using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2786 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 2, 3, 6, 1, 9, 2 };
            var x = 5;

            var expected = 13;

            var result = MaxScore(nums, x);

            Console.WriteLine(result);

            return result == expected;
        }

        public long MaxScore(int[] nums, int x)
        {
            var n = nums.Length;
            long even = nums[0] % 2 == 0 ? nums[0] : -x;
            long odd = nums[0] % 2 == 1 ? nums[0] : -x;
            for (int i = 1; i < n; ++i)
            {
                if (nums[i] % 2 == 0)
                    even = Math.Max(odd + nums[i] - x, even + nums[i]);
                else
                    odd = Math.Max(even + nums[i] - x, odd + nums[i]);
            }

            return Math.Max(even, odd);
        }
    }
}
