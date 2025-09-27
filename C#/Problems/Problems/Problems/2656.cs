using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2656 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 2, 3, 4, 5 };
            var k = 3;

            var expected = 18;

            var result = MaximizeSum(nums, k);

            Console.WriteLine(result);

            return expected == result;
        }

        public int MaximizeSum(int[] nums, int k)
        {
            var n = nums.Length;
            var biggest = nums[0];
            for (int i = 1; i < n; ++i)
                biggest = Math.Max(biggest, nums[i]);
            return biggest * k + ((k - 1) * k / 2);
        }
    }
}
