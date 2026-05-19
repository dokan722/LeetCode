using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2789 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 2, 3, 7, 9, 3 };

            var expected = 21;

            var result = MaxArrayValue(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public long MaxArrayValue(int[] nums)
        {
            var n = nums.Length;
            long result = 0;
            for (int i = n - 1; i >= 0; --i)
            {
                if (result >= nums[i])
                    result += nums[i];
                else
                    result = nums[i];
            }

            return result;
        }
    }
}
