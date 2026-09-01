using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3568 : IProblem
    {
        public bool Test()
        {
            var classroom = new[] { "RL", "SL", "LR" };
            var energy = 2;

            var expected = 4;

            var result = MinMoves(classroom, energy);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinMoves(string[] classroom, int energy)
        {
            var n = classroom.Length;
            var m = classroom[0].Length;

            var srow = 0;
            var scol = 0;
            var ls = 0;
            var ids = new int[n][];
            var best = new int[n][][];
            for (int i = 0; i < n; ++i)
            {
                ids[i] = new int[m];
                best[i] = new int[m][];
                for (int j = 0; j < m; ++j)
                {
                    if (classroom[i][j] == 'S')
                    {
                        srow = i;
                        scol = j;
                    }
                    else if (classroom[i][j] == 'L')
                        ids[i][j] = ls++;
                }
            }
            var all = (1 << ls) - 1;
            for (int i = 0; i < n; ++i)
                for (int j = 0; j < m; ++j)
                    best[i][j] = Enumerable.Repeat(-1, all + 1).ToArray();
            var que = new Queue<(int X, int Y, int E, int S, int D)>();
            que.Enqueue((srow, scol, energy, 0, 0));
            best[srow][scol][0] = energy;
            var dirs = new[] { new[] { 0, -1 }, new[] { -1, 0 }, new[] { 0, 1 }, new[] { 1, 0 } };
            while (que.Count > 0)
            {
                var (x, y, e, s, d) = que.Dequeue();
                if (s == all)
                    return d;
                if (e == 0)
                    continue;
                foreach (var dir in dirs)
                {
                    var nx = x + dir[0];
                    var ny = y + dir[1];
                    var ns = s;
                    var ne = e - 1;
                    if (nx < 0 || nx >= n || ny < 0 || ny >= m || classroom[nx][ny] == 'X')
                        continue;
                    var o = classroom[nx][ny];
                    if (o == 'L')
                        ns |= (1 << ids[nx][ny]);
                    else if (o == 'R')
                        ne = energy;
                    if (best[nx][ny][ns] >= ne)
                        continue;
                    best[nx][ny][ns] = ne;
                    que.Enqueue((nx, ny, ne, ns, d + 1));
                }
            }

            return -1;
        }
    }
}
