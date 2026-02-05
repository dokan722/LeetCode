using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3379 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 3, -2, 1, 1 };

            var expected = new[] { 1, 1, 1, 3 };

            var result = ConstructTransformedArray(nums);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }

        public int[] ConstructTransformedArray(int[] nums)
        {
            var n = nums.Length;
            var result = new int[n];
            for (int i = 0; i < n; ++i)
                result[i] = nums[((i + nums[i]) % n + n) % n];
            return result;
        }
    }
}
