using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3315 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 2, 3, 5, 7 };

            var expected = new[] { -1, 1, 4, 3 };   

            var result = MinBitwiseArray(nums);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }

        public int[] MinBitwiseArray(IList<int> nums)
        {
            var n = nums.Count;
            var result = new int[n];
            for (int i = 0; i < n; ++i)
            {
                if (nums[i] == 2)
                    result[i] = -1;
                else
                    result[i] = nums[i] - (((nums[i] + 1) & -(nums[i] + 1)) >> 1);
            }

            return result;
        }
    }
}
