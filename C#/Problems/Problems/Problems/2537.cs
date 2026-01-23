using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2537 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 3, 1, 4, 3, 2, 2, 4 };
            var k = 2;

            var expected = 4;

            var result = CountGood(nums, k);

            Console.WriteLine(result);

            return expected == result;
        }

        public long CountGood(int[] nums, int k)
        {
            var n = nums.Length;
            var counts = new Dictionary<int, int>();
            var l = 0;
            var r = -1;
            var p = 0;
            long result = 0;
            while (r < n - 1)
            {
                while (p < k && r < n - 1)
                {
                    r++;
                    if (!counts.ContainsKey(nums[r]))
                        counts[nums[r]] = 0;
                    p += counts[nums[r]];
                    counts[nums[r]]++;
                }
                while (p >= k)
                {
                    result += n - r;
                    counts[nums[l]]--;
                    p -= counts[nums[l]];
                    l++;
                }
            }

            return result;
        }
    }
}
