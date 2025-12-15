using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _945 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 3, 2, 1, 2, 1, 7 };

            var expected = 6;

            var result = MinIncrementForUnique(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinIncrementForUnique(int[] nums)
        {
            var n = nums.Length;
            Array.Sort(nums);
            var curr = -1;
            var result = 0;
            for (int i = 0; i < n; ++i)
            {
                if (nums[i] > curr)
                    curr = nums[i];
                else
                {
                    curr++;
                    result += curr - nums[i];
                }
            }

            return result;
        }
    }
}
