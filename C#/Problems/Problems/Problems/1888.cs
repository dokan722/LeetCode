using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1888 : IProblem
    {
        public bool Test()
        {
            var s = "111000";

            var expected = 2;

            var result = MinFlips(s);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinFlips(string s)
        {
            int n = s.Length;
            var op = new int[] { 0, 0 };

            for (int i = 0; i < n; i++)
                op[(s[i] ^ i) & 1]++;

            int res = Math.Min(op[0], op[1]);

            for (int i = 0; i < n - 1; i++)
            {
                op[(s[i] ^ i) & 1]--;
                op[(s[i] ^ (n + i)) & 1]++;
                res = Math.Min(res, Math.Min(op[0], op[1]));
            }

            return res;
        }
    }
}
