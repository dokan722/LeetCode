using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3432 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 10, 10, 3, 7, 6 };

            var expected = 4;

            var result = CountPartitions(nums);

            Console.WriteLine(result);

            return expected == result;
        }

        public int CountPartitions(int[] nums)
        {
            var n = nums.Length;
            var sum = 0;
            for (int i = 0; i < n; i++)
                sum += nums[i];
            var curr = 0;
            var result = 0;
            for (int i = 0; i < n - 1; ++i)
            {
                curr += nums[i];
                if (curr % 2 == (sum - curr) % 2)
                    result++;
            }

            return result;
        }
    }
}
