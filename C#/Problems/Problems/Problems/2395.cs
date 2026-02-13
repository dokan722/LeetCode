using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2395 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 2, 3, 4, 5 };

            var expected = false;

            var result = FindSubarrays(nums);

            return result == expected;
        }

        public bool FindSubarrays(int[] nums)
        {
            var n = nums.Length;
            var sums = new HashSet<int>();
            for (int i = 1; i < n; ++i)
            {
                var s = nums[i - 1] + nums[i];
                if (sums.Contains(s))
                    return true;
                sums.Add(s);
            }

            return false;
        }
    }
}
