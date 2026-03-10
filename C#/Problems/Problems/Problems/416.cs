using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _416 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 5, 11, 5 };

            var expected = true;

            var result = CanPartition(nums);

            return expected == result;
        }
        public bool CanPartition(int[] nums)
        {
            var s = 0;
            foreach (var num in nums)
                s += num;
            if (s % 2 == 1)
                return false;
            var req = s / 2;
            var dp = new bool[req + 1];
            dp[0] = true;
            foreach (var num in nums)
            {
                for (int i = req; i - num >= 0; --i)
                {
                    dp[i] = dp[i] || dp[i - num];
                }
                if (dp[req])
                    return true;
            }

            return false;
        }
    }
}
