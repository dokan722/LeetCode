using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2717 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 2, 1, 4, 3 };

            var expected = 2;

            var result = SemiOrderedPermutation(nums);

            Console.WriteLine(result);

            return expected == result;
        }

        public int SemiOrderedPermutation(int[] nums)
        {
            var n = nums.Length;
            var first = -1;
            var last = -1;
            for (int i = 0; i < n; ++i)
            {
                if (nums[i] == 1)
                    first = i;
                if (nums[i] == n)
                    last = i;
            }

            return first + (n - last - 1) - (first > last ? 1 : 0);
        }
    }
}
