using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1882 : IProblem
    {
        public bool Test()
        {
            var servers = new[] { 3, 3, 2 };
            var tasks = new[] { 1, 2, 3, 2, 1, 2 };

            var expected = new[] { 2, 2, 0, 2, 1, 2 };

            var result = AssignTasks(servers, tasks);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }

        public int[] AssignTasks(int[] servers, int[] tasks)
        {
            var n = servers.Length;
            var m = tasks.Length;
            var free = new PriorityQueue<int, (int W, int I)>();
            var occ = new PriorityQueue<int, int>();
            for (int i = 0; i < n; ++i)
                free.Enqueue(i, (servers[i], i));
            var result = new int[m];
            var cur = 0;
            for (int i = 0; i < m; ++i)
            {
                if (free.Count == 0)
                    occ.TryPeek(out var _, out cur);
                while (occ.TryPeek(out var _, out var time) && time <= cur)
                {
                    var top = occ.Dequeue();
                    free.Enqueue(top, (servers[top], top));
                }
                if (free.TryDequeue(out var id, out var pri))
                {
                    result[i] = id;
                    occ.Enqueue(id, cur + tasks[i]);
                }
                cur = Math.Max(cur, i + 1);
            }
            return result;
        }
    }
}
