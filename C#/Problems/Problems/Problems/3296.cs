using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{

    // SAME AS 2615
    public class _3296 : IProblem
    {
        public bool Test()
        {
            var mountainHeight = 4;
            var workerTimes = new[] { 2, 1, 1 };

            var expected = 3;

            var result = MinNumberOfSeconds(mountainHeight, workerTimes);

            Console.WriteLine(result);

            return result == expected;
        }

        public long MinNumberOfSeconds(int mountainHeight, int[] workerTimes)
        {
            int n = workerTimes.Length;
            var que = new PriorityQueue<(int Id, int Last), long>();
            for (int i = 0; i < n; ++i)
                que.Enqueue((i, 1), (long)workerTimes[i]);
            long result = 0;
            for (int i = 0; i < mountainHeight; ++i)
            {
                que.TryPeek(out var par, out var val);
                que.Dequeue();
                result = val;
                que.Enqueue((par.Id, par.Last + 1), val + (long)(par.Last + 1) * workerTimes[par.Id]);
            }
            return result;
        }
    }
}
