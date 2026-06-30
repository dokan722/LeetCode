using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3976 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, -2, 3, 4, -5 };
            var k = 2;

            var expected = 14;

            var result = MaxSubarraySum(nums, k);

            Console.WriteLine(result);

            return result == expected;
        }

        public long MaxSubarraySum(int[] nums, int k)
        {
            long curBase = 0;
            long curMult = 0;
            long curDiv = 0;
            long curAfter = 0;
            long result = int.MinValue;
            foreach (var num in nums)
            {
                long mult = (long)num * k;
                long div = (long)num / k;
                curAfter = Math.Max(Math.Max(curMult + num, curDiv + num), curAfter + num);
                curMult = Math.Max(Math.Max(curBase + mult, curMult + mult), mult);
                curDiv = Math.Max(Math.Max(curBase + div, curDiv + div), div);
                curBase = Math.Max(curBase + num, num);
                result = Math.Max(result, Math.Max(Math.Max(curBase, curAfter), Math.Max(curDiv, curMult)));
            }
            return result;
        }
    }
}
