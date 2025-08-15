using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3232 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 2, 3, 4, 10 };

            var expected = false;

            var result = CanAliceWin(nums);

            return result == expected;
        }

        public bool CanAliceWin(int[] nums)
        {
            var sumDigit = 0;
            var sumOther = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] < 10)
                    sumDigit += nums[i];
                else
                    sumOther += nums[i];
            }

            return sumDigit != sumOther;
        }
    }
}
