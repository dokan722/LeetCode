using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2553 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 13, 25, 83, 77 };

            var expected = new[] { 1, 3, 2, 5, 8, 3, 7, 7 };

            var result = SeparateDigits(nums);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }

        public int[] SeparateDigits(int[] nums)
        {
            var n = nums.Length;
            var result = new List<int>();
            for (int i = n - 1; i >= 0; --i)
            {
                var num = nums[i];
                while (num > 0)
                {
                    result.Add(num % 10);
                    num /= 10;
                }
            }
            result.Reverse();
            return result.ToArray();
        }
    }
}
