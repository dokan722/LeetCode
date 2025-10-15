using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1247 : IProblem
    {
        public bool Test()
        {
            var s1 = "xy";
            var s2 = "yx";

            var expected = 2;

            var result = MinimumSwap(s1, s2);

            Console.WriteLine(result);

            return expected == result;
        }

        public int MinimumSwap(string s1, string s2)
        {
            var n = s1.Length;
            var xs = 0;
            var ys = 0;
            for (int i = 0; i < n; i++)
            {
                if (s1[i] == s2[i])
                    continue;
                if (s1[i] == 'x')
                    xs++;
                else
                    ys++;
            }

            if (xs % 2 != ys % 2)
                return -1;
            return xs % 2 == 0 ? (xs + ys) / 2 : (ys + xs) / 2 + 1;
        }
    }
}
