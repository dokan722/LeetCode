using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2485 : IProblem
    {
        public bool Test()
        {
            var n = 8;

            var expected = 6;

            var result = PivotInteger(n);

            Console.WriteLine(result);

            return expected == result;
        }

        public int PivotInteger(int n)
        {
            var pivotValue = Math.Sqrt((n * n + n) / 2.0);
            return pivotValue % 1 == 0 ? (int)pivotValue : -1;
        }
    }
}
