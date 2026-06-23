using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3699 : IProblem
    {
        public bool Test()
        {
            var n = 3;
            var l = 4;
            var r = 5;

            var expected = 2;

            var result = ZigZagArrays(n, l, r);

            Console.WriteLine(result);

            return result == expected;
        }

        public int ZigZagArrays(int n, int l, int r)
        {
            var dp0 = new int[r + 1];
            var dp1 = new int[r + 1];
            var sum0 = new int[r + 2];
            var sum1 = new int[r + 2];
            var mod = 1000000007;


            for (int i = l; i <= r; i++)
            {
                dp0[i] = dp1[i] = 1;
                sum0[i] = sum1[i] = i - l + 1;
            }

            for (int i = 1; i < n; i++)
            {
                for (int j = l; j <= r; j++)
                {
                    dp0[j] = (sum1[r] - sum1[j] + mod) % mod;
                    dp1[j] = sum0[j - 1];
                }

                sum0[l] = dp0[l];
                sum1[l] = dp1[l];
                for (int j = l + 1; j <= r; j++)
                {
                    sum0[j] = (sum0[j - 1] + dp0[j]) % mod;
                    sum1[j] = (sum1[j - 1] + dp1[j]) % mod;
                }
            }

            return (sum0[r] + sum1[r]) % mod;
        }
    }
}
