using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3628 : IProblem
    {
        public bool Test()
        {
            var s = "LMCT";

            var expected = 2;

            var result = NumOfSubsequences(s);

            Console.WriteLine(result);

            return result == expected;
        }

        public long NumOfSubsequences(string s)
        {
            long ls = 0;
            long cs = 0;
            long ts = 0;
            foreach (var c in s)
            {
                if (c == 'L')
                    ls++;
                else if (c == 'C')
                    cs++;
                else if (c == 'T')
                    ts++;
            }
            long count = 0;
            long bestc = 0;
            long bestl = 0;
            long bestt = 0;
            long curls = 0;
            long curcs = 0;
            long curts = 0;
            foreach (var c in s)
            {
                if (c == 'L' || c == 'T')
                {
                    bestc = Math.Max(bestc, curls * (ts - curts));
                    if (c == 'L')
                    {
                        bestt += cs - curcs;
                        curls++;
                    }
                    else
                    {
                        bestl += curcs;
                        curts++;
                    }
                }
                else if (c == 'C')
                {
                    count += curls * (ts - curts);
                    curcs++;
                }
            }

            return Math.Max(count + bestc, Math.Max(count + bestl, count + bestt));
        }
    }
}
