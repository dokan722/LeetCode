using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1929 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 3, 2, 1 };

            var expected = new[] { 1, 3, 2, 1, 1, 3, 2, 1 };

            var result = GetConcatenation(nums);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(result, expected);
        }

        public int[] GetConcatenation(int[] nums)
        {
            var n = nums.Length;
            var result = new int[2 * n];
            for (int i = 0; i < n; i++)
            {
                result[i] = nums[i];
                result[n + i] = nums[i];
            }

            return result; 
        }
    }
}
