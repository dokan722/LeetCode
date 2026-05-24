using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2091 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 2, 10, 7, 5, 4, 1, 8, 6 };

            var expected = 5;

            var result = MinimumDeletions(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinimumDeletions(int[] nums)
        {
            var n = nums.Length;
            var maxId = 0;
            var minId = 0;
            for (int i = 1; i < n; ++i)
            {
                if (nums[i] > nums[maxId])
                    maxId = i;
                else if (nums[i] < nums[minId])
                    minId = i;
            }
            var first = Math.Min(maxId, minId);
            var second = Math.Max(maxId, minId);
            return Math.Min(second + 1, Math.Min(n - first, first + 1 + (n - second)));
        }
    }
}
