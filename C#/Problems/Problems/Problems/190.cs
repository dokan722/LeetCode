using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _190 : IProblem
    {
        public bool Test()
        {
            var n = 43261596;

            var expected = 964176192;

            var result = ReverseBits(n);

            Console.WriteLine(result);

            return expected == result;
        }

        public int ReverseBits(int n)
        {
            return ReverseRec(n, 32);
        }

        private int ReverseRec(int n, int l)
        {
            if (l == 1)
                return n & 1;

            int half = l >> 1;
            int mask = (1 << half) - 1;
            int lo = n & mask;
            int hi = n >> half;

            return (ReverseRec(lo, half) << half) | ReverseRec(hi, half);
        }
    }
}
