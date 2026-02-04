using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3818 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, -1, 2, 3, 3, 4, 5 };

            var expected = 4;

            var result = MinimumPrefixLength(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinimumPrefixLength(int[] nums)
        {
            var n = nums.Length;
            for (int i = n - 2; i >= 0; --i)
            {
                if (nums[i] >= nums[i + 1])
                    return i + 1;
            }

            return 0;
        }
    }
}
