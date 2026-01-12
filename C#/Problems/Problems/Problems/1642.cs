using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1642 : IProblem
    {
        public bool Test()
        {
            var heights = new[] { 4, 2, 7, 6, 9, 14, 12 };
            var bricks = 5;
            var ladders = 1;

            var expected = 4;

            var result = FurthestBuilding(heights, bricks, ladders);

            Console.WriteLine(result);

            return result == expected;
        }
        public int FurthestBuilding(int[] heights, int bricks, int ladders)
        {
            var n = heights.Length;
            var used = new PriorityQueue<int, int>();
            for (int i = 1; i < n; ++i)
            {
                var diff = heights[i] - heights[i - 1];
                if (diff <= 0)
                    continue;
                if (ladders > 0)
                {
                    used.Enqueue(diff, diff);
                    ladders--;
                }
                else if (used.TryPeek(out var _, out var h) && h < diff)
                {
                    used.Dequeue();
                    used.Enqueue(diff, diff);
                    bricks -= h;
                }
                else
                    bricks -= diff;

                if (bricks < 0)
                    return i - 1;
            }

            return n - 1;
        }
    }
}
