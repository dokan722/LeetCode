using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1829 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 0, 1, 1, 3 };
            var maximumBit = 2;

            var expected = new[] { 0, 3, 2, 3 };

            var result = GetMaximumXor(nums, maximumBit);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }

        public int[] GetMaximumXor(int[] nums, int maximumBit)
        {
            var n = nums.Length;
            var cur = 0;
            var result = new int[n];
            var mask = (1 << maximumBit) - 1;
            for (int i = 0; i < n; ++i)
            {
                cur ^= nums[i];
                result[n - 1 - i] = (mask ^ cur);
            }
            return result;
        }
    }
}
