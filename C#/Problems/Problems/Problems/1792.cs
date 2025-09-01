using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1792 : IProblem
    {
        public bool Test()
        {
            var classes = new[] { new[] { 583, 868 }, new[] { 783, 822 }, new[] { 65, 262 }, new[] { 121, 508 }, new[] { 461, 780 }, new[] { 484, 668 } };
            var extraStudents = 8;

            var expected = 0.57472;

            var result = MaxAverageRatio(classes, extraStudents);

            Console.WriteLine(result);

            return Math.Abs(expected - result) < 1e-5;
        }

        public double MaxAverageRatio(int[][] classes, int extraStudents)
        {
            var n = classes.Length;
            var profits = new PriorityQueue<int, double>(Comparer<double>.Create((x, y) => y.CompareTo(x)));
            for (int i = 0; i < n; ++i)
                profits.Enqueue(i, (double)(classes[i][0] + 1) / (classes[i][1] + 1) - (double)classes[i][0] / classes[i][1]);
            for (int i = 0; i < extraStudents; ++i)
            {
                var best = profits.Dequeue();
                classes[best][0]++;
                classes[best][1]++;
                profits.Enqueue(best, (double)(classes[best][0] + 1) / (classes[best][1] + 1) - (double)classes[best][0] / classes[best][1]);
            }

            var result = 0.0;
            for (int i = 0; i < n; ++i)
                result += (double)classes[i][0] / classes[i][1];

            return result / n;
        }
    }
}
