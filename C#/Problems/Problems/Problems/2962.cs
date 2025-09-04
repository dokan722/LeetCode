using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2962 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 3, 2, 3, 3 };
            var k = 2;

            var expected = 6;

            var result = CountSubarrays(nums, k);

            Console.WriteLine(result);

            return result == expected;
        }

        public long CountSubarrays(int[] nums, int k)
        {
            var n = nums.Length;
            var max = nums.Max();
            var count = 0;
            long result = 0;
            int j = 0;
            for (int i = 0; i < n; ++i)
            {
                if (nums[i] == max)
                    count++;
                while (j < n && count >= k)
                {
                    result += n - i;
                    if (nums[j] == max)
                        count--;
                    j++;
                }
            }

            return result;
        }
    }
}
