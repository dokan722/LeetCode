using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1920 : IProblem
    {
        public bool Test()
        {
            var nums = new int[] { 0, 2, 1, 5, 3, 4 };
            var expected = new int[] { 0, 1, 2, 4, 5, 3 };

            var result = BuildArray(nums);

            Console.WriteLine(string.Join(",", result));

            return result.SequenceEqual(expected);
        }

        public int[] BuildArray(int[] nums)
        {
            int n = nums.Length;
            for (int i = 0; i < n; ++i)
            {
                nums[i] += 1000 * (nums[nums[i]] % 1000);
            }

            for (int i = 0; i < n; ++i)
            {
                nums[i] /= 1000;
            }
            return nums;
        }
    }
}
