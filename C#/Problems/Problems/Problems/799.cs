using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _799 : IProblem
    {
        public bool Test()
        {
            var poured = 100000009;
            var query_row = 33;
            var query_glass = 17;

            var expected = 1.0;

            var result = ChampagneTower(poured, query_row, query_glass);

            Console.WriteLine(result);

            return Math.Abs(expected - result) < 1e-5;
        }
        public double ChampagneTower(int poured, int query_row, int query_glass)
        {
            var row = new double[1];
            row[0] = poured;
            for (int i = 1; i <= query_row; ++i)
            {
                var currRow = new double[i + 1];
                currRow[0] = Math.Max(0, (row[0] - 1) / 2);
                currRow[i] = Math.Max(0, (row[i - 1] - 1) / 2);
                for (int j = 1; j < i; ++j)
                    currRow[j] = Math.Max(0, (Math.Max(0, row[j - 1] - 1) + Math.Max(0, row[j] - 1)) / 2);
                row = currRow;
            }

            return Math.Min(1, row[query_glass]);
        }
    }
}
