using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1942 : IProblem
    {
        public bool Test()
        {
            var times = new[]
            {
                new[] { 33, 35 }, new[] { 26, 29 }, new[] { 9, 28 }, new[] { 4, 31 }, new[] { 8, 10 }, new[] { 32, 34 },
                new[] { 15, 24 }, new[] { 27, 39 }, new[] { 14, 36 }, new[] { 1, 14 }, new[] { 25, 39 },
                new[] { 5, 27 }, new[] { 6, 15 }, new[] { 2, 38 }, new[] { 19, 36 }, new[] { 24, 34 }, new[] { 3, 26 }
            };
            var targetFriend = 0;

            var expected = 3;

            var result = SmallestChair(times, targetFriend);

            Console.WriteLine(result);

            return expected == result;
        }

        public int SmallestChair(int[][] times, int targetFriend)
        {
            var n = times.Length;
            var chairQueue = new PriorityQueue<int, int>();
            var occupiedChairs = new PriorityQueue<int, int>();
            var timesInOrder = times.Select((x, i) => (Id: i, Arrival: x[0], Leaving: x[1])).OrderBy(x => x.Arrival).ToArray();
            for (int i = 0; i < n; ++i)
                chairQueue.Enqueue(i, i);
            for (int i = 0; i < n; ++i)
            {
                var cur = timesInOrder[i];
                while (occupiedChairs.TryPeek(out var chair, out var time) && time <= cur.Arrival)
                {
                    occupiedChairs.Dequeue();
                    chairQueue.Enqueue(chair, chair);
                }
                if (timesInOrder[i].Id == targetFriend)
                    break;
                var topChair = chairQueue.Dequeue();
                occupiedChairs.Enqueue(topChair, cur.Leaving);
            }

            return chairQueue.Dequeue();
        }
    }
}
