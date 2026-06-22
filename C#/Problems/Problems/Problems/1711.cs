using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1711 : IProblem
    {
        public bool Test()
        {
            var deliciousness = new[] { 1, 3, 5, 7, 9 };

            var expected = 4;

            var result = CountPairs(deliciousness);

            Console.WriteLine(result);

            return result == expected;
        }
        public int CountPairs(int[] deliciousness)
        {
            var pows = new int[22];
            pows[0] = 1;
            var b = 2;
            var mod = 1000000007;
            for (int i = 1; i <= 21; ++i)
            {
                pows[i] = b;
                b <<= 1;
            }
            var counts = new Dictionary<int, int>();
            long result = 0;
            foreach (var d in deliciousness)
            {
                foreach (var p in pows)
                {
                    var exp = p - d;
                    if (counts.ContainsKey(exp))
                        result = (result + counts[exp]) % mod;
                }
                if (!counts.ContainsKey(d))
                    counts[d] = 1;
                else
                    counts[d]++;
            }

            return (int)result;
        }
    }
}
