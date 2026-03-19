using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1208 : IProblem
    {
        public bool Test()
        {
            var s = "iktqzyazth";
            var t = "havakbjzzc";
            var maxCost = 78;

            var expected = 8;

            var result = EqualSubstring(s, t, maxCost);

            Console.WriteLine(result);

            return result == expected;
        }
        public int EqualSubstring(string s, string t, int maxCost)
        {
            var n = s.Length;
            var currCost = 0;
            var r = 0;
            var result = 0;
            for (int i = 0; i < n; ++i)
            {
                if (i > 0)
                    currCost -= Math.Abs(s[i - 1] - t[i - 1]);
                while (r < n && currCost <= maxCost)
                {
                    currCost += Math.Abs(s[r] - t[r]);
                    r++;
                }
                result = Math.Max(result, r - i - 1);
                if (r == n)
                {
                    if (currCost <= maxCost)
                        result = Math.Max(result, r - i);
                    break;
                }
            }

            return result;
        }
    }
}
 