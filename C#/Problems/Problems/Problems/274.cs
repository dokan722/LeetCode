using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _274 : IProblem
    {
        public bool Test()
        {
            var citations = new[] { 3, 0, 6, 1, 5 };

            var expected = 3;

            var result = HIndex(citations);

            Console.WriteLine(result);

            return result == expected;
        }

        public int HIndex(int[] citations)
        {
            var counts = new int[1001];
            foreach (var c in citations)
                counts[c]++;
            var cur = 0;
            for (int i = 1000; i >= 0; --i)
            {
                cur += counts[i];
                if (cur >= i)
                    return i;
            }

            return 0;
        }
    }
}
