using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3523 : IProblem
    {
        public bool Test()
        {
            var nums = new[] {4, 2, 5, 3, 5};

            var expected = 3;

            var result = MaximumPossibleSize(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MaximumPossibleSize(int[] nums)
        {
            var n = nums.Length;
            var reduced = 0;
            for (int i = 1; i < n; i++)
            {
                if (nums[i] > nums[i - 1])
                    continue;
                int j = i;
                while (j < n && nums[j] < nums[i - 1])
                    j++;
                reduced += j - i;
                i = j;
            }

            return n - reduced;
        }
    }
}
