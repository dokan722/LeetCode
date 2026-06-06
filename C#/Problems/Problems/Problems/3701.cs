using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3701 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 3, 5, 7 };

            var expected = -4;

            var result = AlternatingSum(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public int AlternatingSum(int[] nums)
        {
            var n = nums.Length;
            var result = 0;
            for (int i = 0; i < n; ++i)
            {
                if (i % 2 == 0)
                    result += nums[i];
                else
                    result -= nums[i];
            }

            return result;
        }
    }
}
