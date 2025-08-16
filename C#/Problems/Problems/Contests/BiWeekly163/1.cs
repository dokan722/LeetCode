using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problems.Problems;

namespace Problems.Contests.BiWeekly163
{
    public class _1 : IProblem
    {
        public bool Test()
        {
            var n = 2;
            var m = 2;
            var k = 2;

            var expected = 1;

            var result = MinSensors(n, m, k);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinSensors(int n, int m, int k)
        {
            var range = 2 * k + 1;
            var inRow = (n + range - 1) / range;
            var inColumn = (m + range - 1) / range;

            return inRow * inColumn;
        }
    }
}
