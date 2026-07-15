using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3856 : IProblem
    {
        public bool Test()
        {
            var n = 4;

            var expected = 4;

            var result = GcdOfOddEvenSums(n);

            Console.WriteLine(result);

            return result == expected;
        }

        public int GcdOfOddEvenSums(int n)
        {
            return n;
        }
    }
}
