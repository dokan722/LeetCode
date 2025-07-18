using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1480 : IProblem
    {
        public bool Test()
        {
            var nums = new int[] { 1, 2, 3, 4 };

            var expected = new int[] { 1, 3, 6, 10 };

            var result = RunningSum(nums);

            Console.WriteLine(string.Join(", ", result));

            return result.SequenceEqual(expected);
        }

        public int[] RunningSum(int[] nums)
        {
            for (int i = 1; i < nums.Length; i++)
            {
                nums[i] += nums[i - 1];
            }

            return nums;
        }
    }
}
