using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _667 : IProblem
    {
        public bool Test()
        {
            var n = 3;
            var k = 1;

            var expected = new[] { 1, 2, 3 };

            var result = ConstructArray(n, k);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }

        public int[] ConstructArray(int n, int k)
        {
            var result = new int[n];
            var diff = n - k;
            result[0] = 1;
            for (int i = 1; i < diff; ++i)
                result[i] = result[i - 1] + 1;
            for (int i = 1; i <= k; ++i)
                result[diff + i - 1] = (i % 2 == 0) ? (n - k + i / 2) : (n - i / 2);
            return result;
        }
    }
}
