using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2461 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 5, 4, 2, 9, 9, 9 };
            var k = 3;

            var expected = 15;

            var result = MaximumSubarraySum(nums, k);

            Console.WriteLine(result);

            return result == expected;
        }

        public long MaximumSubarraySum(int[] nums, int k)
        {
            var n = nums.Length;
            long s = 0;
            var present = new Dictionary<int, int>();
            for (int i = 0; i < k; ++i)
            {
                s += nums[i];
                if (present.ContainsKey(nums[i]))
                    present[nums[i]]++;
                else
                    present[nums[i]] = 1;
            }

            long result = 0;
            if (present.Count == k)
                result = s;
            for (int i = k; i < n; ++i)
            {
                s += nums[i];
                if (present.ContainsKey(nums[i]))
                    present[nums[i]]++;
                else
                    present[nums[i]] = 1;

                s -= nums[i - k];
                present[nums[i - k]]--;
                if (present[nums[i - k]] <= 0)
                    present.Remove(nums[i - k]);

                if (present.Count == k)
                    result = Math.Max(result, s);
            }

            return result;
        }
    }
}
