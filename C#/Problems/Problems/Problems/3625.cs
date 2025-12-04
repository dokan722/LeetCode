using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3625 : IProblem
    {
        public bool Test()
        {
            var points = new[] { new[] { -3, 2 }, new[] { 3, 0 }, new[] { 2, 3 }, new[] { 3, 2 }, new[] { 2, -3 } };

            var expected = 2;

            var result = CountTrapezoids(points);

            Console.WriteLine(result);

            return result == expected;
        }

        public int CountTrapezoids(int[][] points)
        {
            var n = points.Length;
            var trap = new Dictionary<double, Dictionary<double, int>>();
            var par = new Dictionary<double, Dictionary<double, int>>();
            for (int i = 0; i < n; ++i)
            {
                var x1 = points[i][0];
                var y1 = points[i][1];
                for (int j = i + 1; j < n; ++j)
                {
                    var x2 = points[j][0];
                    var y2 = points[j][1];
                    var dx = x1 - x2;
                    var dy = y1 - y2;
                    double a, b;
                    if (x1 == x2)
                    {
                        a = double.MaxValue;
                        b = x1;
                    }
                    else
                    {
                        a = (double)(y2 - y1) / (x2 - x1);
                        b = (double)(y1 * dx - x1 * dy) / dx;
                    }

                    var mid = (x1 + x2) * 10000.0 + (y1 + y2);
                    if (!trap.ContainsKey(a))
                        trap[a] = new();
                    if (!par.ContainsKey(mid))
                        par[mid] = new();
                    if (!trap[a].ContainsKey(b))
                        trap[a][b] = 1;
                    else
                        trap[a][b]++;
                    if (!par[mid].ContainsKey(a))
                        par[mid][a] = 1;
                    else
                        par[mid][a]++;
                }
            }

            var result = 0;
            foreach (var t in trap.Values)
            {
                int curr = 0;
                foreach (int count in t.Values)
                {
                    result += curr * count;
                    curr += count;
                }
            }

            foreach (var p in par.Values)
            { 
                int curr = 0;
                foreach (int count in p.Values)
                {
                    result -= curr * count;
                    curr += count;
                }
            }

            return result;
        }
    }
}
