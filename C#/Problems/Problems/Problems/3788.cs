using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3788 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 10, -1, 3, -4, -5 };

            var expected = 17;

            var result = MaximumScore(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public long MaximumScore(int[] nums)
        {
            var n = nums.Length;
            long s = 0;
            foreach (var num in nums)
                s += num;
            long result = int.MinValue;
            var m = int.MaxValue;
            for (int i = n - 1; i > 0; --i)
            {
                m = Math.Min(m, nums[i]);
                s -= nums[i];
                result = Math.Max(result, s - m);
            }

            return result;
        }
    }
}
