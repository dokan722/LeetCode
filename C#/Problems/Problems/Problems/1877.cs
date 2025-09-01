using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1877 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 3, 5, 2, 3 };

            var expected = 7;

            var result = MinPairSum(nums);

            Console.WriteLine(result);

            return expected == result;
        }

        public int MinPairSum(int[] nums)
        {
            Array.Sort(nums);
            var half = nums.Length / 2;
            var n = nums.Length;
            var result = 0;
            for (int i = 0; i < half; ++i)
                result = Math.Max(result, nums[i] + nums[n - 1 - i]);

            return result;
        }
    }
}
