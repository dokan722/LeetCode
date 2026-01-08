using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1458 : IProblem
    {
        public bool Test()
        {
            var nums1 = new[] { 2, 1, -2, 5 };
            var nums2 = new[] { 3, 0, -6 };

            var expected = 18;

            var result = MaxDotProduct(nums1, nums2);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MaxDotProduct(int[] nums1, int[] nums2)
        {
            var n = nums1.Length;
            var m = nums2.Length;
            var dp = new int[n][];
            for (int i = 0; i < n; ++i)
                dp[i] = new int[m];
            dp[0][0] = nums1[0] * nums2[0];
            var result = dp[0][0];
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    var takeBoth = nums1[i] * nums2[j] + (i > 0 && j > 0 ? dp[i - 1][j - 1] : 0);
                    var takeBothAndSkip = nums1[i] * nums2[j];
                    var skipFirst = i > 0 ? dp[i - 1][j] : int.MinValue;
                    var skipSecond = j > 0 ? dp[i][j - 1] : int.MinValue;
                    dp[i][j] = Math.Max(takeBoth, Math.Max(takeBothAndSkip, Math.Max(skipFirst, skipSecond)));
                }
            }

            return dp[n - 1][m - 1];
        }
    }
}
