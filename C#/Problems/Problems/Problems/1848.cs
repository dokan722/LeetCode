using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1848 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 2, 3, 4, 5 };
            var target = 5;
            var start = 3;

            var expected = 1;

            var result = GetMinDistance(nums, target, start);

            Console.WriteLine(result);

            return result == expected;
        }

        public int GetMinDistance(int[] nums, int target, int start)
        {
            var n = nums.Length;
            var result = int.MaxValue;
            for (int i = 0; i < n; ++i)
            {
                if (nums[i] == target)
                    result = Math.Min(result, Math.Abs(i - start));
            }

            return result;
        }
    }
}
