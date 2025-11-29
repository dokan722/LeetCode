using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3512 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 3, 9, 7 };
            var k = 5;

            var expected = 4;

            var result = MinOperations(nums, k);

            Console.WriteLine(result);

            return expected == result;
        }

        public int MinOperations(int[] nums, int k)
        {
            var n = nums.Length;
            var sum = 0;
            for (int i = 0; i < n; ++i)
            {
                sum += nums[i];
            }

            return sum % k;
        }
    }
}
