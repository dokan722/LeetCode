using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3423 :IProblem
    {
        public bool Test()
        {
            var nums = new int[] { 1, 2, 4 };


            var expected = 3;

            var result = MaxAdjacentDistance(nums);

            return expected == result;
        }


        public int MaxAdjacentDistance(int[] nums)
        {
            var maxDiff = Math.Abs(nums[nums.Length - 1] - nums[0]);

            for (int i = 0; i < nums.Length - 1; i++)
            {
                var diff = Math.Abs(nums[i] - nums[i + 1]);
                if (diff > maxDiff)
                    maxDiff = diff;
            }

            return maxDiff;
        }
    }
}
