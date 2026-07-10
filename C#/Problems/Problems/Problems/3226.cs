using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3226 : IProblem
    {
        public bool Test()
        {
            var n = 13;
            var k = 4;

            var expected = 2;

            var result = MinChanges(n, k);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinChanges(int n, int k)
        {
            if ((n & k) != k)
                return -1;
            return BitOperations.PopCount((uint)(n & ~k));
        }
    }
}
