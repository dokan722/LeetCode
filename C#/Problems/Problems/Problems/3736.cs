using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3736 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 2, 1, 3 };

            var expected = 3;

            var result = MinMoves(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinMoves(int[] nums)
        {
            var n = nums.Length;
            var result = 0;
            var mx = nums[0];
            for (int i = 1; i < n; ++i)
            {
                if (nums[i] > mx)
                {
                    result += (nums[i] - mx) * i;
                    mx = nums[i];
                }
                else
                    result += mx - nums[i];
            }

            return result;
        }
    }
}
