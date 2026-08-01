using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3275 : IProblem
    {
        public bool Test()
        {
            var queries = new[] { new[] { 1, 2 }, new[] { 3, 4 }, new[] { 2, 3 }, new[] { -3, 0 } };
            var k = 2;

            var expected = new[] { -1, 7, 5, 3 };

            var result = ResultsArray(queries, k);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }

        public int[] ResultsArray(int[][] queries, int k)
        {
            var n = queries.Length;
            var heap = new PriorityQueue<int, int>();
            var result = new int[queries.Length];
            for (int i = 0; i < n; ++i)
            {
                var dist = Math.Abs(queries[i][0]) + Math.Abs(queries[i][1]);
                if (heap.Count < k)
                    heap.Enqueue(-dist, -dist);
                else if (-heap.Peek() > dist)
                {
                    heap.Dequeue();
                    heap.Enqueue(-dist, -dist);
                }
                result[i] = heap.Count == k ? -heap.Peek() : -1;
            }

            return result;
        }
    }
}
