using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3046 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 1, 2, 2, 3, 4 };

            var expected = true;

            var result = IsPossibleToSplit(nums);

            return expected == result;
        }

        public bool IsPossibleToSplit(int[] nums)
        {
            var counts = new int[101];
            foreach (var num in nums)
            {
                if (counts[num] >= 2)
                    return false;
                counts[num]++;
            }

            return true;
        }
    }
}
