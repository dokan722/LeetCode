using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _136 : IProblem
    {
        public bool Test()
        {
            var nums = new int[] { 2, 2, 1 };

            var expected = 1;

            var result = SingleNumber(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public int SingleNumber(int[] nums)
        {

            return nums.Aggregate((x, y) => x ^ y);
        }
    }
}
