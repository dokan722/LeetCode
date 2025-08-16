using Problems.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Contests.BiWeekly163
{
    public class _2 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 0, 1, 2, 3 };

            var expected = 2;

            var result = PerfectPairs(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public long PerfectPairs(int[] nums)
        {
            var n = nums.Length;
            long doubled = 0;
            for (int i = 0; i < n; ++i)
                nums[i] = nums[i] < 0 ? -nums[i] : nums[i];
            Array.Sort(nums);
            var prev = 0;
            var next = 0;
            for (int i = 0; i < n; ++i)
            {
                while (2 * nums[prev] < nums[i])
                    prev++;
                while (next < n && nums[next] <= 2 * nums[i])
                    next++;

                doubled += Math.Max(0, next - prev - 1);
            }

            return doubled / 2;
        }
    }
}
