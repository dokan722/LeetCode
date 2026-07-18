using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1979 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 2, 5, 6, 9, 10 };

            var expected = 2;

            var result = FindGCD(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public int FindGCD(int[] nums)
        {
            var mx = 0;
            var mn = 1001;
            foreach (var num in nums)
            {
                mn = Math.Min(mn, num);
                mx = Math.Max(mx, num);
            }

            while (mn != 0)
            {
                mx %= mn;
                (mx, mn) = (mn, mx);
            }

            return mx;
        }
    }
}
