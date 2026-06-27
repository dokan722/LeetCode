using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3688 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 2, 3, 4, 5, 6 };

            var expected = 6;

            var result = EvenNumberBitwiseORs(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public int EvenNumberBitwiseORs(int[] nums)
        {
            var result = 0;
            foreach (var num in nums)
                if (num % 2 == 0)
                    result |= num;

            return result;
        }
    }
}
