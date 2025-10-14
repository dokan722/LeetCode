using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3159 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 3, 1, 7 };
            var queries = new[] { 1, 3, 2, 4 };
            var x = 1;

            var expected = new[] { 0, -1, 2, -1 };

            var result = OccurrencesOfElement(nums, queries, x);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }

        public int[] OccurrencesOfElement(int[] nums, int[] queries, int x)
        {
            var n = nums.Length;
            var ids = new List<int>();
            for (int i = 0; i < n; i++)
            {
                if (nums[i] == x)
                    ids.Add(i);
            }

            var m = queries.Length;
            var maxId = ids.Count;
            if (maxId == 0)
                return Enumerable.Repeat(-1, m).ToArray();
            var result = new int[m];
            
            for (int i = 0; i < m; ++i)
                result[i] = queries[i] <= maxId ? ids[queries[i] - 1] : -1;

            return result;
        }
    }
}
