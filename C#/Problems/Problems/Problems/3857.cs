using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3857 : IProblem
    {
        public bool Test()
        {
            var n = 3;

            var expected = 3;

            var result = MinCost(n);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinCost(int n)
        {
            return n * (n - 1) / 2;
        }
    }
}
