using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2210 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 2, 4, 1, 1, 6, 5 };

            var expected = 3;

            var result = CountHillValley(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public int CountHillValley(int[] nums)
        {
            var n = nums.Length;
            var result = 0;
            var prev = 0;
            for (int i = 1; i < n - 1; ++i)
            {
                while (i < n && nums[i] == nums[prev])
                    i += 1;
                if (i == n)
                    break;
                var next = i;
                while (next < n && nums[next] == nums[i])
                    next++;
                if (next == n)
                    break;
                if ((nums[prev] < nums[i] && nums[next] < nums[i]) ||
                    (nums[prev] > nums[i] && nums[next] > nums[i]))
                    result += 1;
                prev = i;
                i = next - 1;
            }

            return result;
        }
    }
}
