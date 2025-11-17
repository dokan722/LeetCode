using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2958 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 2, 3, 1, 2, 3, 1, 2 };
            var k = 2;

            var expected = 6;

            var result = MaxSubarrayLength(nums, k);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MaxSubarrayLength(int[] nums, int k)
        {
            var n = nums.Length;
            var counts = new Dictionary<int, int>();
            var j = 0;
            var result = 0;
            for (int i = 0; i < n; ++i)
            {
                if (counts.ContainsKey(nums[i]))
                {
                    counts[nums[i]]++;
                    if (counts[nums[i]] > k)
                    {
                        result = Math.Max(result, i - j);
                        while (counts[nums[i]] > k)
                        {
                            counts[nums[j]]--;
                            j++;
                        }
                    }
                }
                else
                    counts[nums[i]] = 1;
            }

            result = Math.Max(result, n - j);

            return result;
        }
    }
}
