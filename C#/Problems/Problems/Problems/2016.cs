using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2016 : IProblem
    {
        public bool Test()
        {
            var nums = new int[] { 1, 2, 10, 5, 9 };


            var expected = 9;

            var result = MaximumDifference(nums);

            Console.WriteLine(result);

            return expected == result;
        }
        public int MaximumDifference(int[] nums)
        {
            int result = int.MinValue;

            var minSoFar = int.MaxValue;

            for (int i = 1; i < nums.Length; ++i)
            {
                if (nums[i - 1] < minSoFar)
                    minSoFar = nums[i - 1];
                var diff = nums[i] - minSoFar;
                if (diff > result)
                    result = diff;
            }

            return result <= 0 ? -1 : result;
        }
    }
}
