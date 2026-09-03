using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3876 : IProblem
    {
        public bool Test()
        {
            var nums1 = new[] { 1, 4, 7 };

            var expected = true;

            var result = UniformArray(nums1);

            return result == expected;
        }

        public bool UniformArray(int[] nums1)
        {
            var mn = nums1[0];
            var odd = false;
            foreach (var n in nums1)
            {
                mn = Math.Min(mn, n);
                if (n % 2 == 1)
                    odd = true;
            }
            if (mn % 2 == 1)
                return true;
            return !odd;
        }
    }
}
