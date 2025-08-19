using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2348 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 3, 0, 0, 2, 0, 0, 4 };

            var expected = 6;

            var result = ZeroFilledSubarray(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public long ZeroFilledSubarray(int[] nums)
        {
            var n = nums.Length;
            long result = 0;
            for (int i = 0; i < n; ++i)
            {
                if (nums[i] == 0)
                {
                    var begin = i;
                    while (i < n && nums[i] == 0)
                        i++;
                    long zeroCount = i - begin;
                    result += zeroCount * (zeroCount + 1) / 2;
                }
            }

            return result;
        }
    }
}
