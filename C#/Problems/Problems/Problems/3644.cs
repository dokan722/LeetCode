using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3644 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 0, 3, 2, 1 };

            var expected = 1;

            var result = SortPermutation(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public int SortPermutation(int[] nums)
        {
            var n = nums.Length;
            var result = -1;
            for (int i = 0; i < n; ++i)
            {
                if (nums[i] != i)
                {
                    if (result == -1)
                        result = nums[i];
                    else
                        result &= nums[i];
                }
            }

            return result == -1 ? 0 : result;
        }
    }
}
