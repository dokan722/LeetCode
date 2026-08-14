using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3192 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 0, 1, 1, 0, 1 };

            var expected = 4;

            var result = MinOperations(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinOperations(int[] nums)
        {
            var flipped = false;
            var result = 0;
            foreach (var num in nums)
            {
                if ((flipped && num == 1) || (!flipped && num == 0))
                {
                    result += 1;
                    flipped = !flipped;
                }
            }
            return result;
        }
    }
}
