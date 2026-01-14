using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2225 : IProblem
    {
        public bool Test()
        {
            var matches = new[] { new[] { 2, 3 }, new[] { 1, 3 }, new[] { 5, 4 }, new[] { 6, 4 } };

            var expected = new[] { new[] { 1, 2, 5, 6 }, Array.Empty<int>() };

            var result = FindWinners(matches).Select(x => x.ToArray()).ToArray();

            Utils.Print2DArray(result);

            return Utils.Compare2DArrays(expected, result);
        }

        public IList<IList<int>> FindWinners(int[][] matches)
        {
            var results = new SortedDictionary<int, int>();
            foreach (var match in matches)
            {
                if (!results.ContainsKey(match[0]))
                    results[match[0]] = 0;
                if (!results.ContainsKey(match[1]))
                    results[match[1]] = 0;
                results[match[1]]++;
            }

            var no = new List<int>();
            var one = new List<int>();

            foreach (var result in results)
            {
                if (result.Value == 0)
                    no.Add(result.Key);
                else if (result.Value == 1)
                    one.Add(result.Key);
            }

            return new List<IList<int>>() { no, one };
        }
    }
}
