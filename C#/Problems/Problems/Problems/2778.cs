using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2778 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 2, 3, 4 };

            var expected = 21;

            var result = SumOfSquares(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public int SumOfSquares(int[] nums)
        {
            var n = nums.Length;
            var result = 0;
            for (int i = 1; i <= n; ++i)
            {
                if (n % i == 0)
                    result += nums[i - 1] * nums[i - 1];
            }

            return result;
        }
    }
}
