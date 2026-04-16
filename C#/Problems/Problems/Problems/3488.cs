using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3488 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 3, 1, 4, 1, 3, 2 };
            var queries = new[] { 0, 3, 5 };

            var expected = new[] { 2, -1, 3 };

            var result = SolveQueries(nums, queries);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }

        public IList<int> SolveQueries(int[] nums, int[] queries)
        {
            var n = nums.Length;
            var m = queries.Length;
            var result = new int[m];
            var dists = Enumerable.Repeat(int.MaxValue, n).ToArray();
            var pos = new Dictionary<int, (int FP, int LP)>();
            for (int i = 0; i < n; ++i)
            {
                if (!pos.ContainsKey(nums[i]))
                    pos[nums[i]] = (i, i);
                else
                {
                    var p = pos[nums[i]];
                    var back = i - p.LP;
                    var front = n - i + p.FP;
                    pos[nums[i]] = (p.FP, i);
                    dists[i] = Math.Min(back, front);
                    dists[p.FP] = Math.Min(dists[p.FP], front);
                    dists[p.LP] = Math.Min(dists[p.LP], back);
                }
            }

            for (int i = 0; i < m; ++i)
                result[i] = dists[queries[i]] == int.MaxValue ? -1 : dists[queries[i]];

            return result;
        }
    }
}
