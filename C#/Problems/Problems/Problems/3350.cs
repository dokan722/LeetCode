using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3350 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 2, 5, 7, 8, 9, 2, 3, 4, 3, 1 };

            var expected = 3;

            var result = MaxIncreasingSubarrays(nums);

            Console.WriteLine(result);

            return expected == result;
        }
        public int MaxIncreasingSubarrays(IList<int> nums)
        {
            var n = nums.Count;
            var l = 1;
            var prev = 0;
            var result = 0;
            for (int i = 1; i < n; ++i)
            {
                if (nums[i - 1] >= nums[i])
                {
                    result = Math.Max(result, l / 2);
                    prev = l;
                    l = 0;
                }

                l++;
                result = Math.Max(result, Math.Min(l, prev));
            }
            result = Math.Max(result, l / 2);

            return result;
        }
    }
}
