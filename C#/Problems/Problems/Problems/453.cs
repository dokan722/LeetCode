using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _453 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 2, 3 };

            var expected = 3;

            var result = MinMoves(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinMoves(int[] nums)
        {
            var n = nums.Length;
            var m = int.MaxValue;
            var sum = 0;
            for (int i = 0; i < n; ++i)
            {
                sum += nums[i];
                m = Math.Min(m, nums[i]);
            }
            return sum - n * m;
        }
    }
}
