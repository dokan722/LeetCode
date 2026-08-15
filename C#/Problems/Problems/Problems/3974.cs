using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3974 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 6, 1, 2, 9 };
            var k = 3;
            var mul = 2;

            var expected = 26;

            var result = MaxSum(nums, k, mul);

            Console.WriteLine(result);

            return result == expected;
        }

        public long MaxSum(int[] nums, int k, int mul)
        {
            var n = nums.Length;
            Array.Sort(nums);
            long result = 0;
            for (int i = 0; i < k; ++i)
            {
                if (mul > 1)
                {
                    result += (long)nums[n - i - 1] * mul;
                    mul--;
                }
                else
                    result += nums[n - i - 1];
            }

            return result;
        }
    }
}
