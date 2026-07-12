using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1331 : IProblem
    {
        public bool Test()
        {
            var arr = new[] { 40, 10, 20, 30 };

            var expected = new[] { 4, 1, 2, 3 };

            var result = ArrayRankTransform(arr);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }

        public int[] ArrayRankTransform(int[] arr)
        {
            var n = arr.Length;
            var dic = new Dictionary<int, int>();
            var sorted = arr.OrderBy(x => x).ToArray();
            var cur = 1;
            for (int i = 0; i < n; ++i)
            {
                if (!dic.ContainsKey(sorted[i]))
                {
                    dic[sorted[i]] = cur;
                    cur += 1;
                }
            }
            var result = new int[n];
            for (int i = 0; i < n; ++i)
                result[i] = dic[arr[i]];

            return result;
        }
    }
}
