using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3578 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 9, 4, 1, 3, 7 };
            var k = 4;

            var expected = 6;

            var result = CountPartitions(nums, k);

            Console.WriteLine(result);

            return result == expected;
        }
        public int CountPartitions(int[] nums, int k)
        {
            int n = nums.Length;
            int mod = 1000000007;
            long[] dp = new long[n + 1];
            long[] prefix = new long[n + 1];

            SortedSet<int> cnt = new SortedSet<int>();
            Dictionary<int, int> freq = new Dictionary<int, int>();
            dp[0] = 1;
            prefix[0] = 1;

            for (int i = 0, j = 0; i < n; i++)
            {
                int num = nums[i];
                cnt.Add(num);
                freq[num] = freq.GetValueOrDefault(num) + 1;
                while (j <= i && cnt.Max - cnt.Min > k)
                {
                    int key = nums[j];
                    freq[key]--;
                    if (freq[key] == 0)
                    {
                        cnt.Remove(key);
                        freq.Remove(key);
                    }
                    j++;
                }

                dp[i + 1] = j > 0 ? (prefix[i] - prefix[j - 1] + mod) % mod : prefix[i];
                prefix[i + 1] = (prefix[i] + dp[i + 1]) % mod;
            }

            return (int)dp[n];
        }
    }
}
