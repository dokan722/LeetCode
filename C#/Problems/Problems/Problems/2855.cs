using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2855 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 3, 4, 5, 1, 2 };

            var expected = 2;

            var result = MinimumRightShifts(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinimumRightShifts(IList<int> nums)
        {
            var n = nums.Count;
            var pos = nums[n - 1] >= nums[0] ? n - 1 : -1;
            for (int i = 0; i < n - 1; ++i)
            {
                if (nums[i] > nums[i + 1])
                {
                    if (pos != -1)
                        return -1;
                    pos = i;
                }
            }

            return n - pos - 1;
        }
    }
}
