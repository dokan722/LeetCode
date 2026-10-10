using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2333 : IProblem
    {
        public bool Test()
        {
            var nums1 = new[] { 1, 2, 3, 4 };
            var nums2 = new[] { 2, 10, 20, 19 };
            var k1 = 0;
            var k2 = 0;

            var expected = 579;

            var result = MinSumSquareDiff(nums1, nums2, k1, k2);

            Console.WriteLine(result);

            return expected == result;
        }

        public long MinSumSquareDiff(int[] nums1, int[] nums2, int k1, int k2)
        {
            var n = nums1.Length;
            var abs = new int[n];
            for (int i = 0; i < n; ++i)
                abs[i] = Math.Abs(nums1[i] - nums2[i]);
            Array.Sort(abs);
            long tot = k1 + k2;
            long th = abs[n - 1];
            long result = 0;
            var bord = n - 1;
            for (int i = n - 2; i >= 0; --i)
            {
                var req = (long)(abs[bord] - abs[i]) * (n - i - 1);
                if (req <= tot)
                {
                    tot -= req;
                    th = abs[i];
                    bord = i;
                }
                else
                    result += (long)abs[i] * abs[i];
            }
            if (bord == 0 && tot > n * th)
                return 0;
            var eq = n - bord;
            var extra = tot / eq;
            th -= extra;
            tot -= extra * eq;
            result += tot * (long)(th - 1) * (th - 1) + (eq - tot) * (long)th * th;

            return result;
        }
    }
}
