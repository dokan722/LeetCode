using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1775 : IProblem
    {
        public bool Test()
        {
            var nums1 = new[] { 1, 2, 3, 4, 5, 6 };
            var nums2 = new[] { 1, 1, 2, 2, 2, 2 };

            var expected = 3;

            var result = MinOperations(nums1, nums2);

            Console.WriteLine(result);

            return expected == result;
        }

        public int MinOperations(int[] nums1, int[] nums2)
        {
            var ns = new[] { nums1.Length, nums2.Length };
            var sums = new[] { 0, 0 };
            var counts = new[] { new int[7], new int[7] };
            for (int i = 0; i < ns[0]; ++i)
            {
                sums[0] += nums1[i];
                counts[0][nums1[i]]++;
            }
            for (int i = 0; i < ns[1]; ++i)
            {
                sums[1] += nums2[i];
                counts[1][nums2[i]]++;
            }

            var longer = ns[0] > ns[1] ? 0 : 1;
            var shorter = (longer + 1) % 2;
            var bigger = sums[0] > sums[1] ? 0 : 1;
            var smaller = (bigger + 1) % 2;

            if (ns[longer] > ns[shorter] * 6)
                return -1;

            
            var ops = 0;
            for (int i = 1; i < 6; ++i)
            {
                var diff = sums[bigger] - sums[smaller];
                var currentChange = 6 - i;
                if ((counts[smaller][i] + counts[bigger][7 - i]) * currentChange >= diff)
                {
                    ops += (int)Math.Ceiling(diff / (double)currentChange);
                    break;
                }
                
                ops += counts[smaller][i];
                ops += counts[bigger][7 - i];
                sums[smaller] += counts[smaller][i] * currentChange;
                sums[bigger] -= counts[bigger][7 - i] * currentChange;
                
            }

            return ops;
        }
    }
}
