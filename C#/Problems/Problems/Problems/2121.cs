using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2121 : IProblem
    {
        public bool Test()
        {
            var arr = new[] { 2, 1, 3, 1, 2, 3, 3 };

            var expected = new long[] { 4, 2, 7, 2, 4, 4, 5 };

            var result = GetDistances(arr);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }

        public long[] GetDistances(int[] arr)
        {
            var n = arr.Length;
            var indexes = new Dictionary<int, (int Count, long Val, int Last)>();
            var result = new long[n];
            for (int i = 0; i < n; ++i)
            {
                if (indexes.ContainsKey(arr[i]))
                {
                    var cur = indexes[arr[i]];
                    indexes[arr[i]] = (cur.Count + 1, cur.Val + (long)cur.Count * (i - cur.Last), i);
                }
                else
                    indexes[arr[i]] = (1, 0, i);
                result[i] = indexes[arr[i]].Val;
            }
            indexes.Clear();
            for (int i = n - 1; i >= 0; --i)
            {
                if (indexes.ContainsKey(arr[i]))
                {
                    var cur = indexes[arr[i]];
                    indexes[arr[i]] = (cur.Count + 1, cur.Val + (long)cur.Count * (cur.Last - i), i);
                }
                else
                    indexes[arr[i]] = (1, 0, i);
                result[i] += indexes[arr[i]].Val;
            }
            return result;
        }
    }
}
