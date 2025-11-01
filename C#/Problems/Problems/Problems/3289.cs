using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3289 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 7, 1, 5, 4, 3, 4, 6, 0, 9, 5, 8, 2 };

            var expected = new[] { 4, 5 };

            var result = GetSneakyNumbers(nums);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }

        public int[] GetSneakyNumbers(int[] nums)
        {
            var n = nums.Length;
            var seen = new bool[n];
            var first = -1;
            foreach (var num in nums)
            {
                if (seen[num])
                {
                    if (first != -1)
                        return new[] { first, num };
                    first = num;
                }
                else
                    seen[num] = true;
            }

            return null;
        }
    }
}
