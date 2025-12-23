using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2054 : IProblem
    {
        public bool Test()
        {
            var events = new[] { new[] { 1, 3, 2 }, new[] { 4, 5, 2 }, new[] { 2, 4, 3 } };

            var expected = 4;

            var result = MaxTwoEvents(events);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MaxTwoEvents(int[][] events)
        {
            var ts = new List<(int, int, int)>();
            foreach (var e in events)
            {
                ts.Add((e[0], 0, e[2]));
                ts.Add((e[1], 1, e[2]));
            }

            var result = 0;
            var maxFinished = 0;

            foreach (var t in ts.OrderBy(x => x))
            {
                if (t.Item2 == 0)
                    result = Math.Max(result, t.Item3 + maxFinished);
                else
                    maxFinished = Math.Max(maxFinished, t.Item3);
            }

            return result;
        }
    }
}
