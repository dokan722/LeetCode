using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2918 : IProblem
    {
        public bool Test()
        {
            var nums1 = new[] { 3, 2, 0, 1, 0 };
            var nums2 = new[] { 6, 5, 0 };

            var expected = 12;

            var result = MinSum(nums1, nums2);

            Console.WriteLine(result);

            return result == expected;
        }

        public long MinSum(int[] nums1, int[] nums2)
        {
            long s1 = 0;
            long s2 = 0;
            var z1 = false;
            var z2 = false;
            foreach (var n in nums1)
            {
                if (n == 0)
                {
                    s1++;
                    z1 = true;
                }
                else
                    s1 += n;
            }
            foreach (var n in nums2)
            {
                if (n == 0)
                {
                    s2++;
                    z2 = true;
                }
                else
                    s2 += n;
            }
            if ((s1 < s2 && !z1) || (s1 > s2 && !z2))
                return -1;
            return Math.Max(s1, s2);
        }
    }
}
