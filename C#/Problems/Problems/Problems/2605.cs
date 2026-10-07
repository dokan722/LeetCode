using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2605 : IProblem
    {
        public bool Test()
        {
            var nums1 = new[] { 4, 1, 3 };
            var nums2 = new[] { 5, 7 };

            var expected = 15;

            var result = MinNumber(nums1, nums2);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinNumber(int[] nums1, int[] nums2)
        {
            var min1 = 9;
            var min2 = 9;
            var counts = new int[10];
            foreach (var num in nums1)
            {
                counts[num]++;
                min1 = Math.Min(min1, num);
            }
            foreach (var num in nums2)
            {
                counts[num]++;
                min2 = Math.Min(min2, num);
            }
            for (int i = 1; i < 10; ++i)
            {
                if (counts[i] == 2)
                    return i;
            }
            return 10 * Math.Min(min1, min2) + Math.Max(min1, min2);
        }
    }
}
