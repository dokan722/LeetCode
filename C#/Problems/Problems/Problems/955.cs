using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _955 : IProblem
    {
        public bool Test()
        {
            var strs = new[] { "zyx", "wvu", "tsr" };

            var expected = 3;

            var result = MinDeletionSize(strs);

            Console.WriteLine(result);

            return result == expected;
        }
        public int MinDeletionSize(string[] strs)
        {
            var n = strs.Length;
            var cols = strs[0].Length;
            var result = 0;
            var curr = new string[n];
            for (int i = 0; i < cols; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    curr[j] += strs[j][i];
                }

                var sorted = true;
                for (int j = 1; j < n; ++j)
                {
                    if (String.Compare(curr[j - 1], curr[j], StringComparison.Ordinal) > 0)
                    {
                        sorted = false;
                        break;
                    }
                }

                if (!sorted)
                {
                    result++;
                    for (int j = 0; j < n; ++j)
                    {
                        curr[j] = curr[j].Substring(0, curr[j].Length - 1);
                    }
                }
            }

            return result;
        }
    }
}
