using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1817 : IProblem
    {
        public bool Test()
        {
            var logs = new[] { new[] { 0, 5 }, new[] { 1, 2 }, new[] { 0, 2 }, new[] { 0, 5 }, new[] { 1, 3 } };
            var k = 5;

            var expected = new[] { 0, 2, 0, 0, 0 };

            var result = FindingUsersActiveMinutes(logs, k);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }

        public int[] FindingUsersActiveMinutes(int[][] logs, int k)
        {
            var result = new int[k];
            var acts = new Dictionary<int, HashSet<int>>();
            foreach (var log in logs)
            {
                if (acts.ContainsKey(log[0]))
                    acts[log[0]].Add(log[1]);
                else
                    acts[log[0]] = new HashSet<int> { log[1] };
            }

            foreach (var act in acts)
            {
                result[act.Value.Count - 1]++;
            }

            return result;
        }
    }
}
