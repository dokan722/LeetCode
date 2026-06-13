using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2425 : IProblem
    {
        public bool Test()
        {
            var nums1 = new[] { 2, 1, 3 };
            var nums2 = new[] { 10, 2, 5, 0 };

            var expected = 13;

            var result = XorAllNums(nums1, nums2);

            Console.WriteLine(result);

            return result == expected;
        }

        public int XorAllNums(int[] nums1, int[] nums2)
        {
            var result = 0;
            var n = nums1.Length;
            var m = nums2.Length;
            if (n % 2 == 1)
            {
                foreach (var num in nums2)
                    result ^= num;
            }
            if (m % 2 == 1)
            {
                foreach (var num in nums1)
                    result ^= num;
            }

            return result;
        }
    }
}
