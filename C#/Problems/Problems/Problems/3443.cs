using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3443 : IProblem
    {
        public bool Test()
        {
            var s = "NWSE";
            var k = 1;

            var expected = 3;

            var result = MaxDistance(s, k);

            Console.WriteLine(result);

            return expected == result;
        }

        public int MaxDistance(string s, int k)
        {
            int ns = 0;
            int ss = 0;
            int ws = 0;
            int es = 0;
            var result = 0;

            foreach (var c in s)
            {
                switch (c)
                {
                    case 'N':
                        ns++; break;
                    case 'S':
                        ss++; break;
                    case 'W':
                        ws++; break;
                    case 'E':
                        es++; break;
                }

                var maxChangeNS = Math.Min(k, Math.Min(ns, ss));
                var maxChangeWE = Math.Min(k - maxChangeNS, Math.Min(es, ws));

                var maxDist = (Math.Max(ns, ss) - Math.Min(ns, ss)) + (Math.Max(ws, es) - Math.Min(ws, es)) + 2 * (maxChangeWE + maxChangeNS);
                if (maxDist > result)
                    result = maxDist;
            }

            return result;
        }
    }
}
