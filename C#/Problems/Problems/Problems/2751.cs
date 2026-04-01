using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2751 : IProblem
    {
        public bool Test()
        {
            var positions = new[] { 3, 5, 2, 6 };
            var healths = new[] { 10, 10, 15, 12 };
            var directions = "RLRL";

            var expected = new[] { 14 };

            var result = SurvivedRobotsHealths(positions, healths, directions).ToArray();

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }

        public IList<int> SurvivedRobotsHealths(int[] positions, int[] healths, string directions)
        {
            var n = positions.Length;
            var right = new Stack<(int Val, int Pos)>();
            var left = new List<(int Val, int Pos)>();
            var ids = Enumerable.Range(0, n).ToArray();
            Array.Sort(ids, (x, y) => positions[x].CompareTo(positions[y]));
            for (int i = 0; i < n; ++i)
            {
                var id = ids[i];
                if (directions[id] == 'R')
                    right.Push((healths[id], id));
                else
                {
                    var cur = healths[id];
                    while (right.Count > 0 && right.Peek().Val < cur)
                    {
                        right.Pop();
                        cur--;
                    }
                    if (right.Count == 0)
                        left.Add((cur, id));
                    else if (cur == right.Peek().Val)
                        right.Pop();
                    else
                    {
                        var top = right.Pop();
                        right.Push((top.Val - 1, top.Pos));
                    }
                }
            }
            var result = left.Concat(right).OrderBy(x => x.Pos).Select(x => x.Val).ToList();
            return result;
        }
    }
}
