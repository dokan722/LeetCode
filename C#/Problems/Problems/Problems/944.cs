using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _944 : IProblem
    {
        public bool Test()
        {
            var strs = new[] { "cba", "daf", "ghi" };

            var expected = 1;

            var result = MinDeletionSize(strs);

            Console.WriteLine(result);

            return result == expected;
        }
        public int MinDeletionSize(string[] strs)
        {
            var n = strs.Length;
            var cols = strs[0].Length;
            var result = 0;
            for (int i = 0; i < cols; ++i)
            {
                for (int j = 1; j < n; ++j)
                {
                    if (strs[j - 1][i] > strs[j][i])
                    {
                        result++;
                        break;
                    }
                }
            }

            return result;
        }

    }
}
