using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1200 : IProblem
    {
        public bool Test()
        {
            var arr = new[] { 3, 8, -10, 23, 19, -4, -14, 27 };

            var expected = new[] { new[] { -14, -10 }, new[] { 19, 23 }, new[] { 23, 27 } };

            var result = MinimumAbsDifference(arr).Select(x => x.ToArray()).ToArray();

            Utils.Print2DArray(result);

            return Utils.Compare2DArrays(expected, result);
        }

        public IList<IList<int>> MinimumAbsDifference(int[] arr)
        {
            var arrLength = arr.Length;
            Array.Sort(arr);
            var minDiff = arr[1] - arr[0];
            List<IList<int>> result = new List<IList<int>> { new List<int> { arr[0], arr[1] } };
            for (int i = 2; i < arrLength; ++i)
            {
                var curDiff = arr[i] - arr[i - 1];
                if (curDiff == minDiff)
                    result.Add(new List<int> { arr[i - 1], arr[i] });
                else if (curDiff < minDiff)
                {
                    minDiff = curDiff;
                    result = new List<IList<int>> { new List<int> { arr[i - 1], arr[i] } };
                }
            }

            return result;
        }
    }
}
