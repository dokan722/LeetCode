using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2587 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 2, -1, 0, 1, -3, 3, -3 };

            var expected = 6;

            var result = MaxScore(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MaxScore(int[] nums)
        {
            var n = nums.Length;
            Array.Sort(nums);
            long pre = 0;
            for (int i = n - 1; i >= 0; --i)
            {
                pre += nums[i];
                if (pre <= 0)
                    return n - i - 1;
            }

            return n;
        }
    }
}
