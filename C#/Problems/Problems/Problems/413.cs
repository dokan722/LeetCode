using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _413 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 2, 3, 4 };

            var expected = 3;

            var result = NumberOfArithmeticSlices(nums);

            Console.WriteLine(result);

            return expected == result;
        }

        public int NumberOfArithmeticSlices(int[] nums)
        {
            var n = nums.Length;
            if (n < 3)
                return 0;
            var result = 0;
            var start = 0;
            var prevDiff = nums[0] - nums[1];
            for (int i = 2; i < n; i++)
            {
                var diff = nums[i - 1] - nums[i];
                if (diff == prevDiff)
                    continue;
                var len = i - start;
                if (len >= 3)
                    result += (len - 2) * (len - 1) / 2;
                start = i - 1;
                prevDiff = diff;
            }
            var final = n - start;
            if (final >= 3)
                result += (final - 2) * (final - 1) / 2;

            return result;
        }
    }
}
