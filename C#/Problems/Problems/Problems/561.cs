using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _561 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 4, 3, 2 };

            var expected = 4;

            var result = ArrayPairSum(nums);

            Console.WriteLine(result);

            return expected == result;
        }
        public int ArrayPairSum(int[] nums)
        {
            var n = nums.Length;
            Array.Sort(nums);
            var result = 0;
            for (int i = 0; i < n; i += 2)
            {
                result += nums[i];
            }

            return result;
        }

    }
}
