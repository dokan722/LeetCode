using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2357 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 5, 0, 3, 5 };

            var expected = 3;

            var result = MinimumOperations(nums);

            Console.WriteLine(result);

            return result == expected;
        }
        public int MinimumOperations(int[] nums)
        {
            var n = nums.Length;
            var present = new bool[101];
            var result = 0;
            for (int i = 0; i < n; ++i)
            {
                if (!present[nums[i]])
                {
                    present[nums[i]] = true;
                    result++;
                }
            }
            if (present[0])
                result--;
            return result;
        }

    }
}
