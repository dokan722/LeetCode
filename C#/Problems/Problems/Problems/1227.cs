using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1227 : IProblem
    {
        public bool Test()
        {
            var n = 2;

            var expected = 0.5;

            var result = NthPersonGetsNthSeat(n);

            Console.WriteLine(result);

            return result == expected;
        }

        public double NthPersonGetsNthSeat(int n)
        {
            if (n == 1)
                return 1.0;
            return 0.5;
        }
    }
}
