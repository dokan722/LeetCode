using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _39 : IProblem
    {
        public bool Test()
        {
            var candidates = new[] { 2, 3, 6, 7 };
            var target = 7;

            var expected = new[] { new[] { 2, 2, 3 }, new[] { 7 } };

            var result = CombinationSum(candidates, target);

            Utils.Print2DArray(result);

            return Utils.Compare2DArrays(expected, result);
        }
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            var result = new List<IList<int>>();
            var cur = new List<int>();
            SearchRec(result, cur, candidates, target, 0);
            return result;
        }

        private void SearchRec(IList<IList<int>> result, IList<int> cur, int[] cands, int rem, int start)
        {
            if (rem < 0)
                return;
            if (rem == 0)
            {
                result.Add(new List<int>(cur));
                return;
            }
            for (int i = start; i < cands.Length; ++i)
            {
                cur.Add(cands[i]);
                SearchRec(result, cur, cands, rem - cands[i], i);
                cur.RemoveAt(cur.Count - 1);
            }
        }
    }
}
