using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1523 : IProblem
    {
        public bool Test()
        {
            var low = 3;
            var high = 7;

            var expected = 3;

            var result = CountOdds(low, high);

            Console.WriteLine(result);

            return expected == result;
        }

        public int CountOdds(int low, int high)
        {
            var l = high - low + 1;
            if (l % 2 == 0)
                return l / 2;
            if (low % 2 == 1)
                return (l + 1) / 2;
            return (l - 1) / 2;
        }
    }
}
