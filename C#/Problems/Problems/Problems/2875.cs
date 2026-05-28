using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2875 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 5, 5, 4, 1, 2, 2, 2, 3, 2, 4, 2, 5 };
            var target = 56;

            var expected = 16;

            var result = MinSizeSubarray(nums, target);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinSizeSubarray(int[] nums, int target)
        {
            var n = nums.Length;
            long s = 0;
            for (int i = 0; i < n; ++i)
                s += nums[i];
            var extra = (int)(target / s);
            var extraElems = n * extra;
            target -= (int)(extra * s);
            var r = 0;
            var result = int.MaxValue;
            long cs = 0;
            for (int i = 0; i < n; ++i)
            {
                while (r < 2 * n && cs < target)
                {
                    cs += nums[r % n];
                    r++;
                }
                if (cs == target)
                    result = Math.Min(result, extraElems + (r - i));
                cs -= nums[i];
            }
            return result == int.MaxValue ? -1 : result;
        }
    }
}
