using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3963 : IProblem
    {
        public bool Test()
        {
            var m = 2;
            var n = 3;

            var expected = new[] { "...", "##." };

            var result = CreateGrid(m, n);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }

        public string[] CreateGrid(int m, int n)
        {
            var result = new string[m];
            result[0] = new string('.', n);
            for (int i = 1; i < m; ++i)
                result[i] = new string('#', n - 1) + ".";

            return result;
        }
    }
}
