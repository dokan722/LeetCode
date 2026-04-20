using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2871 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 0, 2, 0, 1, 2 };

            var expected = 3;

            var result = MaxSubarrays(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MaxSubarrays(int[] nums)
        {
            var result = 0;
            var mask = -1;
            var cur = mask;
            foreach (var num in nums)
            {
                cur &= num;
                if (cur == 0)
                {
                    result++;
                    cur = mask;
                }
            }
            if (result == 0)
                return 1;
            return result;
        }
    }
}
