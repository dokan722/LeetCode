using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3979 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 3, 5, 2, 8 };
            var k = 2;

            var expected = 13;

            var result = MaxValidPairSum(nums, k);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MaxValidPairSum(int[] nums, int k)
        {
            var n = nums.Length;
            var mx = nums[0];
            var result = 0;
            for (int i = 0; i < n - k; ++i)
            {
                mx = Math.Max(mx, nums[i]);
                result = Math.Max(result, mx + nums[i + k]);
            }

            return result;
        }
    }
}
