using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3178 : IProblem
    {
        public bool Test()
        {
            var n = 3;
            var k = 5;

            var expected = 1;

            var result = NumberOfChild(n, k);

            Console.WriteLine(result);

            return result == expected;
        }

        public int NumberOfChild(int n, int k)
        {
            var even = (k / (n - 1)) % 2 == 0;
            return even ? (k % (n - 1)) : n - (k % (n - 1)) - 1;
        }
    }
}
