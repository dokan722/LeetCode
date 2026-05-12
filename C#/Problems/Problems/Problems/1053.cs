using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1053 : IProblem
    {
        public bool Test()
        {
            var arr = new[] { 3, 2, 1 };

            var expected = new[] { 3, 1, 2 };

            var result = PrevPermOpt1(arr);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }
        public int[] PrevPermOpt1(int[] arr)
        {
            var n = arr.Length;
            for (int i = n - 2; i >= 0; --i)
            {
                if (arr[i] > arr[i + 1])
                {
                    var m = n - 1;
                    while (arr[m] >= arr[i] || arr[m - 1] == arr[m])
                        m--;
                    var tmp = arr[i];
                    arr[i] = arr[m];
                    arr[m] = tmp;
                    break;
                }
            }

            return arr;
        }
    }
}
