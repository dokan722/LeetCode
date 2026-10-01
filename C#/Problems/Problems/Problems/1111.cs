using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1111 : IProblem
    {
        public bool Test()
        {
            var seq = "(()())";

            var expected = new[] { 0, 1, 0, 0, 1, 0 };

            var result = MaxDepthAfterSplit(seq);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }

        public int[] MaxDepthAfterSplit(string seq)
        {
            var n = seq.Length;
            var os = 0;
            var es = 0;
            var result = new int[n];
            for (int i = 0; i < n; ++i)
            {
                if (seq[i] == '(')
                {
                    if ((os & 1) == 1)
                        result[i] = 1;
                    os++;
                }
                else
                {
                    if ((es & 1) == 1)
                        result[i] = 1;
                    es++;
                }
            }

            return result;
        }
    }
}
