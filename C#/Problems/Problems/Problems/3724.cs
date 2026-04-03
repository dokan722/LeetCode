using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3724 : IProblem
    {
        public bool Test()
        {
            var nums1 = new[] {2, 8};
            var nums2 = new[] { 1, 7, 3 };

            var expected = 4;

            var result = MinOperations(nums1, nums2);

            Console.WriteLine(result);

            return result == expected;
        }

        public long MinOperations(int[] nums1, int[] nums2)
        {
            var n = nums1.Length;
            long result = 0;
            var last = int.MaxValue;
            for (int i = 0; i < n; ++i)
            {
                result += Math.Abs(nums1[i] - nums2[i]);
                if (Math.Min(nums1[i], nums2[i]) <= nums2[n] && nums2[n] <= Math.Max(nums1[i], nums2[i]))
                    last = 0;
                else
                    last = Math.Min(last, Math.Min(Math.Abs(nums1[i] - nums2[n]), Math.Abs(nums2[i] - nums2[n])));
            }

            return result + last + 1;
        }
    }
}
