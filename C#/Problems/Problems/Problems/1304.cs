using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1304 : IProblem
    {
        public bool Test()
        {
            var n = 5;

            var result = SumZero(n);

            return result.Sum() == 0;
        }

        public int[] SumZero(int n)
        {
            var result = new int[n];
            result[0] = (n * (n - 1)) / 2;
            for (int i = 1; i < n; i++)
                result[i] = -i;

            return result;
        }
    }
}
