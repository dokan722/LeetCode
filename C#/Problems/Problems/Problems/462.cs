using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _462 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 2, 3 };

            var expected = 2;

            var result = MinMoves2(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinMoves2(int[] nums)
        {
            var n = nums.Length;
            Array.Sort(nums);
            var med = nums[n / 2];
            var result = 0;
            for (int i = 0; i < n; ++i)
                result += Math.Abs(nums[i] - med);
            return result;
        }
    }
}
