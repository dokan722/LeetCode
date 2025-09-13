using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _238 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 2, 3, 4 };

            var expected = new[] { 24, 12, 8, 6 };

            var result = ProductExceptSelf(nums);

            return expected.SequenceEqual(result);
        }

        public int[] ProductExceptSelf(int[] nums)
        {
            var n = nums.Length;
            long product = 1;
            var zeroCount = 0;
            var zeroId = -1;
            for (int i = 0; i < n; ++i)
            {
                if (nums[i] != 0)
                    product *= nums[i];
                else
                {
                    zeroCount++;
                    if (zeroCount > 1)
                        return new int[n];
                    zeroId = i;
                }
            }

            if (zeroCount == 1)
            {
                var result = new int[n];
                result[zeroId] = (int)product;
                return result;
            }

            for (int i = 0; i < nums.Length; ++i)
                nums[i] = (int)(product / (nums[i] != 0 ? nums[i] : 1));


            return nums;
        }
    }
}
