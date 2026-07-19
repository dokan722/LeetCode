using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2611 : IProblem
    {
        public bool Test()
        {
            var reward1 = new[] { 1, 1, 3, 4 };
            var reward2 = new[] { 4, 4, 1, 1 };
            var k = 2;

            var expected = 15;

            var result = MiceAndCheese(reward1, reward2, k);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MiceAndCheese(int[] reward1, int[] reward2, int k)
        {
            var n = reward1.Length;
            var ids = Enumerable.Range(0, n).ToArray();
            var diffs = ids.Select(x => reward1[x] - reward2[x]).ToArray();
            Array.Sort(ids, Comparer<int>.Create((x, y) => diffs[y].CompareTo(diffs[x])));
            var result = 0;
            for (int i = 0; i < k; ++i)
                result += reward1[ids[i]];
            for (int i = k; i < n; ++i)
                result += reward2[ids[i]];
            return result;
        }
    }
}
