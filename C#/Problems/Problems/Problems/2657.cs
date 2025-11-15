using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2657 : IProblem
    {
        public bool Test()
        {
            var A = new[] { 1, 3, 2, 4 };
            var B = new[] { 3, 1, 2, 4 };

            var expected = new[] { 0, 2, 3, 4 };

            var result = FindThePrefixCommonArray(A, B);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }

        public int[] FindThePrefixCommonArray(int[] A, int[] B)
        {
            var n = A.Length;
            var curr = 0;
            var result = new int[n];
            var setA = new HashSet<int>();
            var setB = new HashSet<int>();
            for (int i = 0; i < n; ++i)
            {
                if (A[i] == B[i])
                    curr++;
                else
                {
                    if (setA.Contains(B[i]))
                        curr++;
                    if (setB.Contains(A[i]))
                        curr++;
                    setA.Add(A[i]);
                    setB.Add(B[i]);
                }
                result[i] = curr;
            }

            return result;
        }
    }
}
