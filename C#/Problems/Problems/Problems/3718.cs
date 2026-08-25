using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3718 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 8, 2, 3, 4, 6 };
            var k = 2;

            var expected = 10;

            var result = MissingMultiple(nums, k);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MissingMultiple(int[] nums, int k)
        {
            var mx = (100 + k) / k;
            var present = new bool[mx];
            foreach (var n in nums)
                if (n % k == 0)
                    present[n / k] = true;
            for (int i = 1; i < mx; ++i)
                if (!present[i])
                    return i * k;
            return mx * k;
        }
    }
}
