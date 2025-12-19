using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3774 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 5, 2, 2, 4 };
            var k = 2;

            var expected = 5;

            var result = AbsDifference(nums, k);

            Console.WriteLine(result);

            return expected == result;
        }

        public int AbsDifference(int[] nums, int k)
        {
            var n = nums.Length;
            var result = 0;
            Array.Sort(nums);
            for (int i = 0; i < k; ++i)
            {
                result -= nums[i];
                result += nums[n - i - 1];
            }

            return result;
        }
    }
}
