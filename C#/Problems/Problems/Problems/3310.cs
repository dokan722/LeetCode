using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3310 : IProblem
    {
        public bool Test()
        {
            var n = 4;
            var k = 1;
            var invocations = new[] { new[] { 1, 2 }, new[] { 0, 1 }, new[] { 3, 2 } };

            var expected = new[] { 0, 1, 2, 3 };

            var result = RemainingMethods(n, k, invocations);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(result, expected);
        }

        public IList<int> RemainingMethods(int n, int k, int[][] invocations)
        {
            var nig = new List<int>[n];
            for (int i = 0; i < n; ++i)
                nig[i] = new List<int>();
            foreach (var i in invocations)
            {
                nig[i[0]].Add(i[1]);
            }
            var sus = new bool[n];
            var q = new Queue<int>();
            q.Enqueue(k);
            while (q.Count > 0)
            {
                var next = q.Dequeue();
                sus[next] = true;
                foreach (var ni in nig[next])
                {
                    if (!sus[ni])
                        q.Enqueue(ni);
                }
            }
            var result = new List<int>();
            for (int i = 0; i < n; ++i)
            {
                if (sus[i])
                    continue;
                foreach (var ni in nig[i])
                {
                    if (sus[ni])
                        return Enumerable.Range(0, n).ToArray();
                }
                result.Add(i);
            }

            return result;
        }
    }
}
