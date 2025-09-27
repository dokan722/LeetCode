using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1365 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 8, 1, 2, 2, 3 };

            var expected = new[] { 4, 0, 1, 1, 3 };

            var result = SmallerNumbersThanCurrent(nums);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(result, expected);
        }
        public int[] SmallerNumbersThanCurrent(int[] nums)
        {
            var counts = new int[101];
            foreach (var num in nums)
                counts[num]++;
            var smaller = new int[102];
            smaller[0] = 0;
            for (int i = 1; i < 102; ++i)
                smaller[i] = counts[i - 1] + smaller[i - 1];

            for (int i = 0; i < nums.Length; ++i)
                nums[i] = smaller[nums[i]];

            return nums;
        }
    }
}
