using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3727 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, -1, 2, -2, 3, -3 };

            var expected = 16;

            var result = MaxAlternatingSum(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public long MaxAlternatingSum(int[] nums)
        {
            Array.Sort(nums, Comparer<int>.Create((x, y) => Math.Abs(x).CompareTo(Math.Abs(y))));
            var half = nums.Length / 2;
            long score = 0;
            for (int i = 0; i < half; ++i)
                score -= nums[i] * nums[i];
            for (int i = half; i < nums.Length; ++i)
                score += nums[i] * nums[i];
            return score;
        }
    }
}
