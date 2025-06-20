using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1855 :IProblem
    {
        public bool Test()
        {
            var nums1 = new int[] { 55, 30, 5, 4, 2 };

            var nums2 = new int[] { 100, 20, 10, 10, 5 };

            var expected = 2;

            var result = MaxDistance(nums1, nums2);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MaxDistance(int[] nums1, int[] nums2)
        {
            int i = 0;
            int j = 0;

            var result = 0;

            while (i < nums1.Length && j < nums2.Length)
            {
                if (i <= j && nums1[i] <= nums2[j])
                {
                    var dist = j - i;
                    if (dist > result)
                        result = dist;
                    j++;
                }
                else if (i > j)
                    j++;
                else
                    i++;
            }

            return result;
        }
    }
}
