using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3065 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 2, 11, 10, 1, 3 };
            var k = 10;

            var expected = 3;

            var result = MinOperations(nums, k);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinOperations(int[] nums, int k)
        {
            var result = 0;
            foreach (var n in nums)
                if (n < k)
                    result++;
            return result;
        }
    }
}
