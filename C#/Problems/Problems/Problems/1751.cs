using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1751 : IProblem
    {
        public bool Test()
        {
            var events = new int[][] { new int[] { 1, 2, 4 }, new int[] { 3, 4, 3 }, new int[] { 2, 3, 1 } };

            var k = 2;

            var expected = 7;

            var result = MaxValue(events, k);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MaxValue(int[][] events, int k)
        {
            Array.Sort(events, (x,y) => x[0].CompareTo(y[0]));
            int n = events.Length;
            int[][] memory = new int[k + 1][];

            for (int i = 0; i <= k; i++)
            {
                memory[i] = new int[n];
                for (int j = 0; j < n; j++)
                {
                    memory[i][j] = -1;
                }
            }
            var result = CheckScheduleRec(events, memory, 0, k);

            return result;
        }
        public int CheckScheduleRec(int[][] events, int[][] memory, int currEvent, int k)
        {
            if (k == 0 || currEvent == events.Length)
                return 0;
            if (memory[k][currEvent] != -1)
                return memory[k][currEvent];
            var nextFree = events[currEvent][1] + 1;
            var left = currEvent;
            var right = events.Length;
            while (left < right)
            {
                var mid = (left + right) / 2;
                if (events[mid][0] < nextFree)
                    left = mid + 1;
                else
                    right = mid;

            }

            memory[k][currEvent] =  Math.Max(events[currEvent][2] + CheckScheduleRec(events, memory, left, k - 1),
                CheckScheduleRec(events, memory, currEvent + 1, k));
            return memory[k][currEvent];
        }
    }
}
