using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2092 : IProblem
    {
        public bool Test()
        {
            var n = 4;
            var meetings = new[] { new[] { 3, 1, 3 }, new[] { 1, 2, 2 }, new[] { 0, 3, 3 } };
            var firstPerson = 3;

            var expected = new[] { 0, 1, 3 };

            var result = FindAllPeople(n, meetings, firstPerson).ToArray();

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }
        public IList<int> FindAllPeople(int n, int[][] meetings, int firstPerson)
        {
            var ubf = Enumerable.Range(0, n).ToArray();
            Union(0, firstPerson, ubf);
            Array.Sort(meetings, Comparer<int[]>.Create((x, y) => x[2].CompareTo(y[2])));
            var present = new HashSet<int>();
            var prev = meetings[0][2];
            foreach (var meeting in meetings)
            {
                if (prev != meeting[2])
                {
                    foreach (var p in present)
                    {
                        if (Find(p, ubf) == 0)
                            ubf[p] = 0;
                        else
                            ubf[p] = p;
                    }
                    prev = meeting[2];
                    present = new();
                }
                present.Add(meeting[0]);
                present.Add(meeting[1]);
                Union(meeting[0], meeting[1], ubf);
            }
            var result = new List<int>();
            for (int i = 0; i < n; ++i)
            {
                if (Find(i, ubf) == 0)
                    result.Add(i);
            }
            return result;
        }

        private int Find(int x, int[] ubf)
        {
            if (x == ubf[x])
                return x;
            return Find(ubf[x], ubf);
        }

        private void Union(int x, int y, int[] ubf)
        {
            var px = Find(x, ubf);
            var py = Find(y, ubf);
            if (py == 0)
                ubf[px] = 0;
            else
                ubf[py] = px;
        }

    }
}
