using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2579 : IProblem
    {
        public bool Test()
        {
            var n = 2;

            var expected = 5;

            var result = ColoredCells(n);

            Console.WriteLine(result);

            return result == expected;
        }

        public long ColoredCells(int n)
        {
            return (long)(n - 1) * n / 2 * 4 + 1;
        }
    }
}
