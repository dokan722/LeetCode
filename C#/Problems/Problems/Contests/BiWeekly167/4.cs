using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problems.Problems;

namespace Problems.Contests.BiWeekly167
{
    public class _4 : IProblem
    {
        public bool Test()
        {
            var points = new[] { new[] { -67477, 65659 }, new[] { 2392, 89645 }, new[] { -74424, -96183 }, new[] { -60599, -80221 }, new[] { -8966, 45129 } };
            var expected = 93855;

            var result = MaxPartitionFactor(points);

            Console.WriteLine(result);

            return expected == result;
        }

        public int MaxPartitionFactor(int[][] points)
        {
            var n = points.Length;
            if (n <= 2)
                return 0;
            var que = new PriorityQueue<(int P1, int P2), (int dist, int id)>();
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    que.Enqueue((i, j), (Math.Abs(points[i][0] - points[j][0]) + Math.Abs(points[i][1] - points[j][1]), i));
                }
            }

            var first = que.Dequeue();
            var set1 = new HashSet<int>() { first.P1 };
            var set2 = new HashSet<int>() { first.P2  };
            var shouldDivide = Enumerable.Range(0, n).ToDictionary(x => x, x => new Stack<int>());
            while (que.TryDequeue(out var ps, out var prio))
            {
                var dist = prio.dist;
                if ((set1.Contains(ps.P1) && set1.Contains(ps.P2)) || (set2.Contains(ps.P1) && set2.Contains(ps.P2)))
                    return dist;
                if (set1.Contains(ps.P1))
                {
                    set2.Add(ps.P2);
                    while (shouldDivide[ps.P2].TryPop(out var other))
                    {
                        if (set2.Contains(other))
                            return dist;
                        set1.Add(other);
                    }
                }
                else if (set1.Contains(ps.P2))
                {
                    set2.Add(ps.P1);
                    while (shouldDivide[ps.P1].TryPop(out var other))
                    {
                        if (set2.Contains(other))
                            return dist;
                        set1.Add(other);
                    }
                }
                else if (set2.Contains(ps.P1))
                {
                    set1.Add(ps.P2);
                    while (shouldDivide[ps.P2].TryPop(out var other))
                    {
                        if (set1.Contains(other))
                            return dist;
                        set2.Add(other);
                    }
                }
                else if (set2.Contains(ps.P2))
                {
                    set1.Add(ps.P1);
                    while (shouldDivide[ps.P1].TryPop(out var other))
                    {
                        if (set1.Contains(other))
                            return dist;
                        set2.Add(other);
                    }
                }
                else
                {
                    shouldDivide[ps.P1].Push(ps.P2);
                    shouldDivide[ps.P2].Push(ps.P1);
                }
            }

            return 0;
        }
    }
}
