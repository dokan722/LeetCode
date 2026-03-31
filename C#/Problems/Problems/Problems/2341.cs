using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2341 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 3, 2, 1, 3, 2, 2 };

            var expected = new[] { 3, 1 };

            var result = NumberOfPairs(nums);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }
        public int[] NumberOfPairs(int[] nums)
        {
            var n = nums.Length;
            var present = new bool[101];
            var rem = n;
            foreach (var num in nums)
            {
                if (present[num])
                {
                    rem -= 2;
                    present[num] = false;
                }
                else
                    present[num] = true;
            }
            return new[] { (n - rem) / 2, rem };
        }
    }
}
