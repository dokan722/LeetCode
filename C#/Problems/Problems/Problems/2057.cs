using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2057 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 0, 1, 2 };

            var expected = 0;

            var result = SmallestEqual(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public int SmallestEqual(int[] nums)
        {
            var n = nums.Length;
            for (int i = 0; i < n; ++i)
            {
                if (i % 10 == nums[i])
                    return i;
            }

            return -1;
        }
    }
}
