using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Problems.Problems
{
    public class _3445 : IProblem
    {

        public bool Test()
        {
            var n = "1122211";
            var k = 3;

            var expected = 1;

            var result = MaxDifference(n, k);

            Console.WriteLine(result);

            return expected == result;
        }
        public int MaxDifference(string s, int k)
        {
            int n = s.Length;
            int ans = int.MinValue;

            for (char a = '0'; a <= '4'; ++a)
            {
                for (char b = '0'; b <= '4'; ++b)
                {
                    if (a == b)
                    {
                        continue;
                    }
                    int[] best = new int[4];
                    Array.Fill(best, int.MaxValue);

                    int cnt_a = 0, cnt_b = 0;
                    int prev_a = 0, prev_b = 0;
                    int left = -1;

                    for (int right = 0; right < n; ++right)
                    {
                        cnt_a += (s[right] == a) ? 1 : 0;
                        cnt_b += (s[right] == b) ? 1 : 0;

                        while (right - left >= k && cnt_b - prev_b >= 2)
                        {
                            int left_status = GetStatus(prev_a, prev_b);

                            best[left_status] = Math.Min(
                                    best[left_status],
                                    prev_a - prev_b
                            );

                            ++left;
                            prev_a += (s[left] == a) ? 1 : 0;
                            prev_b += (s[left] == b) ? 1 : 0;
                        }

                        int right_status = GetStatus(cnt_a, cnt_b);

                        int required_status = right_status ^ 0b10;

                        if (best[required_status] != int.MaxValue)
                        {
                            ans = Math.Max(
                                    ans,
                                    cnt_a - cnt_b - best[required_status]
                            );
                        }
                    }
                }
            }
            return ans;
        }

        private int GetStatus(int cnt_a, int cnt_b)
        {
            return ((cnt_a & 1) << 1) | (cnt_b & 1);
        }
    }
}
