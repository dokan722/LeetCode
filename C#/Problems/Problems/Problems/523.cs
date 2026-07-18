using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _523 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 23, 2, 4, 6, 7 };
            var k = 6;

            var expected = true;

            var result = CheckSubarraySum(nums, k);

            Console.WriteLine(result);

            return result == expected;
        }

        public bool CheckSubarraySum(int[] nums, int k)
        {
            var n = nums.Length;
            if (n > 2L * k)
                return true;
            var cur = nums[0];
            var last = new HashSet<int>();
            last.Add(0);
            for (int i = 1; i < n; ++i)
            {
                var next = cur + nums[i];
                var req = next % k;
                if (last.Contains(req))
                    return true;
                last.Add(cur % k);
                cur = next;
            }

            return false;
        }
    }
}
