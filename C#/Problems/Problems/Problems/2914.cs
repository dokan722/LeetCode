using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2914 : IProblem
    {
        public bool Test()
        {
            var s = "1001";

            var expected = 2;

            var result = MinChanges(s);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinChanges(string s)
        {
            var n = s.Length;
            var start = 0;
            var curr = s[0];
            var result = 0;
            for (int i = 0; i < n; i++)
            {
                if (s[i] != curr)
                {
                    var len = i - start;
                    if (len % 2 != 0)
                    {
                        result++;
                        i++;
                    }
                    start = i;
                    if (i < n)
                        curr = s[i];
                }
            }

            return result;
        }
    }
}
