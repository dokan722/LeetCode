using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2089 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 2, 5, 2, 3 };
            var target = 2;

            var expected = new[] { 1, 2 };

            var result = TargetIndices(nums, target);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }

        public IList<int> TargetIndices(int[] nums, int target)
        {
            var n = nums.Length;
            var bigger = 0;
            var smaller = 0;
            foreach (var num in nums)
            {
                if (num > target)
                    bigger++;
                else if (num < target)
                    smaller++;
            }
            var targeted = n - bigger - smaller;
            var result = new int[targeted];
            for (int i = 0; i < targeted; ++i)
                result[i] = smaller + i;

            return result;
        }
    }
}
