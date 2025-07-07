using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1353 : IProblem
    {
        public bool Test()
        {
            var events = new int[][] { new int[] { 1, 1 }, new int[] { 1, 4 }, new int[] { 1, 10 } };

            var expected = 3;

            var result = MaxEvents(events);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MaxEvents(int[][] events)
        {
            Array.Sort(events, (x, y) => x[1].CompareTo(y[1]));
            var maxDay = events[^1][1];
            var schedule = new bool[maxDay + 2];
            var result = 0;
            foreach (var e in events)
            {
                for (int i = e[0]; i <= e[1]; ++i)
                {
                    if (!schedule[i])
                    {
                        schedule[i] = true;
                        result++;
                        break;
                    }
                }
            }


            return result;
        }
    }
}
