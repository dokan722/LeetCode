using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2841 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 2, 6, 7, 3, 1, 7 };
            var m = 3;
            var k = 4;

            var expected = 18;

            var result = MaxSum(nums, m, k);

            Console.WriteLine(result);

            return result == expected;
        }

        public long MaxSum(IList<int> nums, int m, int k)
        {
            var n = nums.Count;
            var counts = new Dictionary<int, int>();
            long cur = 0;
            for (int i = 0; i < k; ++i)
            {
                if (!counts.ContainsKey(nums[i]))
                    counts[nums[i]] = 1;
                else
                    counts[nums[i]]++;
                cur += nums[i];
            }
            long result = counts.Count >= m ? cur : 0;
            for (int i = k; i < n; ++i)
            {
                cur += nums[i] - nums[i - k];
                if (!counts.ContainsKey(nums[i]))
                    counts[nums[i]] = 1;
                else
                    counts[nums[i]]++;
                counts[nums[i - k]]--;
                if (counts[nums[i - k]] == 0)
                    counts.Remove(nums[i - k]);
                if (counts.Count >= m)
                    result = Math.Max(result, cur);
            }

            return result;
        }
    }
}
