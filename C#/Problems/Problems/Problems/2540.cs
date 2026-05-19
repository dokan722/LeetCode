using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2540 : IProblem
    {
        public bool Test()
        {
            var nums1 = new[] { 1, 2, 3 };
            var nums2 = new[] { 2, 4 };

            var expected = 2;

            var result = GetCommon(nums1, nums2);

            Console.WriteLine(result);

            return result == expected;
        }

        public int GetCommon(int[] nums1, int[] nums2)
        {
            var n1 = nums1.Length;
            var n2 = nums2.Length;
            var i1 = 0;
            var i2 = 0;
            while (i1 < n1 && i2 < n2)
            {
                if (nums1[i1] == nums2[i2])
                    return nums1[i1];
                if (nums1[i1] < nums2[i2])
                    i1++;
                else
                    i2++;
            }

            return -1;
        }
    }
}
