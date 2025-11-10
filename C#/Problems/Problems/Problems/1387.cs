using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1387 : IProblem
    {
        public bool Test()
        {
            var lo = 7;
            var hi = 11;
            var k = 4;

            var expected = 7;

            var result = GetKth(lo, hi, k);

            Console.WriteLine(result);

            return result == expected;
        }

        public int GetKth(int lo, int hi, int k)
        {
            if (lo == hi)
                return lo;
            var n = hi - lo + 1;
            var pows = Enumerable.Repeat(-1, 3 * hi + 1).ToArray();
            pows[1] = 0;
            var forResult = new (int, int)[n];
            for (int i = 0; i < n; ++i)
            {
                var num = i + lo;
                forResult[i] = (GetPower(num, pows), num);
            }
            Array.Sort(forResult);

            return forResult[k - 1].Item2;
        }

        private int GetPower(int n, int[] pows)
        {
            if (n < pows.Length && pows[n] != -1)
                return pows[n];

            return n % 2 == 0 ? GetPower(n / 2, pows) + 1 : GetPower(3 * n + 1, pows) + 1;
        }
    }
}
