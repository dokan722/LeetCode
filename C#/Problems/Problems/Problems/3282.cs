using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3282 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 3, 1, 5 };

            var expected = 7;

            var result = FindMaximumScore(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public long FindMaximumScore(IList<int> nums)
        {
            var n = nums.Count;
            long result = 0;
            var cur = 0;
            for (int i = 1; i < n; ++i)
            {
                if (nums[i] > nums[cur])
                {
                    result += (long)nums[cur] * (i - cur);
                    cur = i;
                }
            }
            result += (long)nums[cur] * (n - 1 - cur);

            return result;
        }
    }
}
