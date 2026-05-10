using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1921 : IProblem
    {
        public bool Test()
        {
            var dist = new[] { 1, 3, 4 };
            var speed = new[] { 1, 1, 1 };

            var expected = 3;

            var result = EliminateMaximum(dist, speed);

            Console.WriteLine(result);

            return result == expected;
        }

        public int EliminateMaximum(int[] dist, int[] speed)
        {
            var n = dist.Length;
            var turn = new int[n];
            for (int i = 0; i < n; ++i)
            {
                turn[i] = (dist[i] + speed[i] - 1) / speed[i];
            }
            Array.Sort(turn);
            for (int i = 0; i < n; ++i)
            {
                if (turn[i] < i + 1)
                    return i;
            }

            return n;
        }
    }
}
