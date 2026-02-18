using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _693 : IProblem
    {
        public bool Test()
        {
            var n = 11;

            var expected = false;

            var result = HasAlternatingBits(n);

            return expected == result;
        }

        public bool HasAlternatingBits(int n)
        {
            var xor = n ^ (n >> 1);
            return (xor & (xor + 1)) == 0;
        }
    }
}
