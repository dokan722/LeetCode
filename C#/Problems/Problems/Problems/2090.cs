using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2090 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 7, 4, 3, 9, 1, 8, 5, 2, 6 };
            var k = 3;

            var expected = new[] { -1, -1, -1, 5, 4, 4, -1, -1, -1 };

            var result = GetAverages(nums, k);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }

        public int[] GetAverages(int[] nums, int k)
        {
            var n = nums.Length;
            var result = new int[n];
            long s = 0;
            long sl = 2 * k + 1;
            for (int i = 0; i < n + k; ++i)
            {
                if (i < n)
                    s += nums[i];
                if (i >= sl)
                    s -= nums[i - sl];
                if (i >= sl - 1 && i < n)
                    result[i - k] = (int)(s / sl);
                else if (i >= k)
                    result[i - k] = -1;
            }
            return result;
        }
    }
}
