using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3012 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 4, 3, 1 };

            var expected = 1;

            var result = MinimumArrayLength(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinimumArrayLength(int[] nums)
        {
            var mn = int.MaxValue;
            foreach (var num in nums)
                mn = Math.Min(mn, num);
            foreach (var num in nums)
                if (num % mn > 0)
                    return 1;
            var cnt = 0;
            foreach (var num in nums)
                if (num == mn)
                    cnt++;
            return (cnt + 1) / 2;
        }
    }
}
