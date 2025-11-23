using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3190 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 2, 3, 4 };

            var expected = 3;

            var result = MinimumOperations(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinimumOperations(int[] nums)
        {
            var result = 0;
            foreach (var num in nums)
            {
                if (num % 3 != 0)
                    result++;
            }

            return result;
        }
    }
}
