using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2402 : IProblem
    {
        public bool Test()
        {
            var meetings = new int[][] {new int[] {0, 10}, new int[] {1, 6}, new int[] {2, 7}, new int[] {3, 4}};
            var n = 2;

            var expected = 0;

            var result = MostBooked(n, meetings);

            Console.WriteLine(result);

            return expected == result;
        }

        public int MostBooked(int n, int[][] meetings)
        {
            var meetingCounts = new int[n];

            var usedRooms = new PriorityQueue<int, (long End, int Room)>();
            var emptyRooms = new PriorityQueue<int, int>();
            for (int i = 0; i < n; ++i)
                emptyRooms.Enqueue(i, i);
            Array.Sort(meetings, (x, y) => x[0].CompareTo(y[0]));
            foreach (var meeting in meetings)
            {
                long begin = meeting[0];
                long end = meeting[1];
                int room;

                while (usedRooms.TryPeek(out var number, out var priority) && priority.End <= begin)
                {
                    room = usedRooms.Dequeue();
                    emptyRooms.Enqueue(room, room);
                }

                
                if (emptyRooms.Count > 0)
                {
                    room = emptyRooms.Dequeue();
                    usedRooms.Enqueue(room, (end, room));
                }
                else
                {
                    usedRooms.TryDequeue(out room, out var priority);
                    usedRooms.Enqueue(room, (priority.End + end - begin, room));
                }

                meetingCounts[room]++;
            }

            var result = 0;
            var maxCount = meetingCounts[0];
            for (int i = 1; i < n; ++i)
            {
                if (meetingCounts[i] > maxCount)
                {
                    maxCount = meetingCounts[i];
                    result = i;
                }
            }

            return result;
        }
    }
}
