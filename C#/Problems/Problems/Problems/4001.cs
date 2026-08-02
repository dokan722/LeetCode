using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _4001 : IProblem
    {
        public bool Test()
        {
            var series1 = new[] { new[] { 1, 3 }, new[] { 4, 1 } };
            var series2 = new[] { new[] { 2, 2 }, new[] { 5, 2 } };

            var expected = new[] { new[] { 1, 5 }, new[] { 2, 3 }, new[] { 4, 3 }, new[] { 5, 2 } };

            var result = AggregateTimeSeries(series1, series2);

            Utils.Print2DArray(result);

            return Utils.Compare2DArrays(expected, result);
        }

        public IList<IList<int>> AggregateTimeSeries(int[][] series1, int[][] series2)
        {
            var n = series1.Length;
            var m = series2.Length;
            var i = 0;
            var j = 0;
            var result = new List<IList<int>>();
            while (i < n || j < m)
            {
                var c1 = i < n ? series1[i] : new[] { int.MaxValue, 0 };
                var c2 = j < m ? series2[j] : new[] { int.MaxValue, 0 };
                if (c1[0] < c2[0])
                {
                    result.Add(new[] { c1[0], c1[1] + c2[1] });
                    i++;
                }
                else if (c1[0] > c2[0])
                {
                    result.Add(new[] { c2[0], c1[1] + c2[1] });
                    j++;
                }
                else
                {
                    result.Add(new[] { c1[0], c1[1] + c2[1] });
                    i++;
                    j++;
                }
            }

            return result;
        }
    }
}
