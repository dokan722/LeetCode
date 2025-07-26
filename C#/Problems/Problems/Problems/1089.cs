using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1089 : IProblem
    {
        public bool Test()
        {
            var arr = new[] { 1, 0, 2, 3, 0, 4, 5, 0 };

            var expected = new[] { 1, 0, 0, 2, 3, 0, 0, 4 };

            DuplicateZeros(arr);

            return arr.SequenceEqual(expected);
        }

        public void DuplicateZeros(int[] arr)
        {
            var n = arr.Length;
            var result = new int[n];
            int j = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[j] == 0)
                {
                    result[i] = 0;
                    i++;
                    if (i < n)
                        result[i] = 0;
                }
                else
                    result[i] = arr[j];
                j++;
            }

            result.CopyTo(arr.AsSpan());
        }
    }
}
