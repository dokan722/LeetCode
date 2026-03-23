using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2481 : IProblem
    {
        public bool Test()
        {
            var n = 4;

            var expected = 2;

            var result = NumberOfCuts(n);

            Console.WriteLine(result);

            return result == expected;
        }
        public int NumberOfCuts(int n)
        {
            if (n == 1)
                return 0;
            return n % 2 == 0 ? n / 2 : n;
        }
    }
}
