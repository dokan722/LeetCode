using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _45 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 2, 3, 1, 1, 4 };

            var expected = 2;

            var result = Jump(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public int Jump(int[] nums)
        {
            var n = nums.Length;
            var maxReachable = 0;
            var curPos = 0;
            var jumps = 0;
            for (int i = 0; i < n; ++i)
            {
                if (i > curPos)
                {
                    jumps++;
                    curPos = maxReachable;
                }
                maxReachable = Math.Max(maxReachable, i + nums[i]);
            }

            return jumps;
        }
    }
}
