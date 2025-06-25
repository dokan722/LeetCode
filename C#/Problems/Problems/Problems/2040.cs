using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2040 : IProblem
    {
        public bool Test()
        {
            var nums1 = new int[] {-4, -2, 0, 3};

            var nums2 = new int[] { 2, 4 };

            var k = 6;

            var expected = 0;

            var result = KthSmallestProduct(nums1, nums2, k);

            return result == expected;
        }

        public long KthSmallestProduct(int[] nums1, int[] nums2, long k)
        {
            var l = nums1.Length;
            var left = -10000000000L;
            var right = 10000000000L;
            while (left <= right)
            {
                long mid = (left + right) / 2;
                long count = 0;
                for (int i = 0; i < l; i++)
                {
                    count += CountSmaller(nums2, nums1[i], mid);
                }
                if (count < k)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return left;
        }

        private int CountSmaller(int[] nums, long f, long v)
        {
            int l = nums.Length;
            int left = 0;
            var right = l - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                long prod = (long)nums[mid] * f;
                if ((f >= 0 && prod <= v) || (f < 0 && prod > v))
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            if (f >= 0)
            {
                return left;
            }
            return l - left;
        }
    }
}
