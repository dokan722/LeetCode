using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1035 : IProblem
    {
        public bool Test()
        {
            var nums1 = new[] { 2, 5, 1, 2, 5 };
            var nums2 = new[] { 10, 5, 2, 1, 5, 2 };

            var expected = 3;

            var result = MaxUncrossedLines(nums1, nums2);

            Console.WriteLine(result);

            return expected == result;
        }

        public int MaxUncrossedLines(int[] nums1, int[] nums2)
        {
            var n = nums1.Length;
            var m = nums2.Length;
            var dp = new int[n + 1][];
            for (int i = 0; i <= n; ++i)
                dp[i] = new int[m + 1];
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    var takeBoth = dp[i][j] + (nums1[i] == nums2[j] ? 1 : 0);
                    var takeFirst = dp[i][j + 1];
                    var takeSecond = dp[i + 1][j];
                    dp[i + 1][j + 1] = Math.Max(takeBoth, Math.Max(takeFirst, takeSecond));
                }
            }

            return dp[n][m];
        }
    }
}
