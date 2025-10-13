using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1749 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 2, -5, 1, -4, 3, -2 };

            var expected = 8;

            var result = MaxAbsoluteSum(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MaxAbsoluteSum(int[] nums)
        {
            var n = nums.Length;
            var maxPos = 0;
            var maxNeg = 0;
            var sumPos = 0;
            var sumNeg = 0;
            for (int i = 0; i < n; ++i)
            {
                sumPos += nums[i];
                sumNeg += nums[i];
                sumNeg = Math.Min(0, sumNeg);
                sumPos = Math.Max(0, sumPos);
                maxPos = Math.Max(sumPos, maxPos);
                maxNeg = Math.Min(sumNeg, maxNeg);
            }

            return Math.Max(maxPos, Math.Abs(maxNeg));
        }
    }
}
