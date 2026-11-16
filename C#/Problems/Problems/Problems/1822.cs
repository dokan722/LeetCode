using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1822 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { -1, -2, -3, -4, 3, 2, 1 };

            var expected = 1;

            var result = ArraySign(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public int ArraySign(int[] nums)
        {
            var result = 1;
            foreach (var num in nums)
            {
                if (num == 0)
                    return 0;
                if (num < 0)
                    result = -result;
            }

            return result;
        }
    }
}
