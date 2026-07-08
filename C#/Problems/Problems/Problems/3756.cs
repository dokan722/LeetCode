using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3756 : IProblem
    {
        public bool Test()
        {
            var s = "10203004";
            var queries = new[] { new[] { 0, 7 }, new[] { 1, 3 }, new[] { 4, 6 } };

            var expected = new[] { 12340, 4, 9 };

            var result = SumAndMultiply(s, queries);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(result, expected);
        }

        public int[] SumAndMultiply(string s, int[][] queries)
        {
            var n = s.Length;
            var mod = 1000000007;
            var mods = new long[n + 1];
            var sumPref = new long[n + 1];
            var vals = new long[n + 1];
            var lens = new long[n + 1];
            mods[0] = 1;
            long curMod = 1;
            long curVal = 0;
            long l = 0;
            for (int i = 1; i <= n; ++i)
            {
                var c = s[i - 1];
                curMod = (curMod * 10) % mod;
                mods[i] = curMod;
                sumPref[i] = sumPref[i - 1] + c - '0';
                if (c != '0')
                {
                    curVal = (curVal * 10 + c - '0') % mod;
                    l++;
                }
                vals[i] = curVal;
                lens[i] = l;
            }

            var m = queries.Length;
            var result = new int[m];
            for (int i = 0; i < m; ++i)
            {
                var q = queries[i];
                long val = (((vals[q[1] + 1] - vals[q[0]] * mods[lens[q[1] + 1] - lens[q[0]]]) % mod) + mod) % mod;
                var sm = sumPref[q[1] + 1] - sumPref[q[0]];
                result[i] = (int)((val * sm) % mod);
            }
            return result;
        }
    }
}
