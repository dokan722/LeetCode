using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3634 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 6, 2, 9 };
            var k = 3;

            var expected = 2;

            var result = MinRemoval(nums, k);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinRemoval(int[] nums, int k)
        {
            var n = nums.Length;
            var result = 0;
            Array.Sort(nums);
            var r = 0;
            for (int i = 0; i < n; ++i)
            {
                while (r < n && (long)nums[i] * k >= nums[r])
                    r++;
                result = Math.Max(r - i, result);
            }

            return n - result;
        }
    }
}
