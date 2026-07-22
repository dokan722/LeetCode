using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3499 : IProblem
    {
        public bool Test()
        {
            var s = "0100";

            var expected = 4;

            var result = MaxActiveSectionsAfterTrade(s);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MaxActiveSectionsAfterTrade(string s)
        {
            var n = s.Length;
            var bs = "1" + s + "1";
            var count = -1;
            var result = 0;
            var po = 0;
            var o = 0;
            var z = 0;
            for (int i = 1; i <= n + 1; ++i)
            {
                if (bs[i] == '1')
                    count++;
                if (bs[i - 1] == '1' && bs[i] == '0')
                {
                    po = o;
                    o = i;
                }
                else if (bs[i - 1] == '0' && bs[i] == '1')
                {
                    if (z != 0)
                        result = Math.Max(result, i - po - o + z);
                    z = i;
                }
            }

            return count + result;
        }
    }
}
