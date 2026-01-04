using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1911 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 6, 2, 1, 2, 4, 5 };

            var expected = 10;

            var result = MaxAlternatingSum(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public long MaxAlternatingSum(int[] nums)
        {
            var n = nums.Length;
            long even = 0;
            long odd = nums[0];
            for (int i = 1; i < n; ++i)
            {
                even = Math.Max(even, odd - nums[i]);
                odd = Math.Max(odd, even + nums[i]);
            }


            return Math.Max(even, odd);
        }
    }
}
