using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1072 : IProblem
    {
        public bool Test()
        {
            var matrix = new[] { new[] { 0, 1 }, new[] { 1, 0 } };

            var expected = 2;

            var result = MaxEqualRowsAfterFlips(matrix);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MaxEqualRowsAfterFlips(int[][] matrix)
        {
            var n = matrix.Length;
            var m = matrix[0].Length;
            var result = 0;
            var counts = new Dictionary<string, int>();
            for (int i = 0; i < n; ++i)
            {
                var pat1 = "";
                var pat2 = "";
                for (int j = 0; j < m; ++j)
                {
                    if (matrix[i][j] == 0)
                    {
                        pat1 += "0";
                        pat2 += "1";
                    }
                    else
                    {
                        pat1 += "1";
                        pat2 += "0";
                    }
                }
                if (counts.ContainsKey(pat1))
                    counts[pat1]++;
                else
                    counts[pat1] = 1;
                if (counts.ContainsKey(pat2))
                    counts[pat2]++;
                else
                    counts[pat2] = 1;
                result = Math.Max(result, Math.Max(counts[pat1], counts[pat2]));
            }

            return result;
        }
    }
}
