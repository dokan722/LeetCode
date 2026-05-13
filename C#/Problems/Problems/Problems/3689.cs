using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3689 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 3, 2 };
            var k = 2;

            var expected = 4;

            var result = MaxTotalValue(nums, k);

            Console.WriteLine(result);

            return result == expected;
        }

        public long MaxTotalValue(int[] nums, int k)
        {
            var mx = int.MinValue;
            var mn = int.MaxValue;
            foreach (var num in nums)
            {
                mx = Math.Max(mx, num);
                mn = Math.Min(mn, num);
            }

            return (long)(mx - mn) * k;
        }
    }
}
