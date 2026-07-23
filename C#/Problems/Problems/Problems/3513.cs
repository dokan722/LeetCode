using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3513 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 2 };

            var expected = 2;

            var result = UniqueXorTriplets(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public int UniqueXorTriplets(int[] nums)
        {
            var n = nums.Length;
            if (n <= 2)
                return n;
            var num = 1;
            while (num <= n)
                num <<= 1;
            return num;
        }
    }
}
