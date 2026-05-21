using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _740 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 3, 4, 2 };

            var expected = 6;

            var result = DeleteAndEarn(nums);

            Console.WriteLine(result);

            return expected == result;
        }

        public int DeleteAndEarn(int[] nums)
        {
            var counts = new int[10001];
            var mx = 0;
            foreach (var num in nums)
            {
                counts[num]++;
                mx = Math.Max(mx, num);
            }
            var dp = new int[mx + 1];
            dp[0] = 0;
            dp[1] = counts[1];
            for (int i = 2; i <= mx; ++i)
            {
                dp[i] = Math.Max(dp[i - 1], counts[i] * i + dp[i - 2]);
            }
            return dp[mx];
        }
    }
}
