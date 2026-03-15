using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3746 : IProblem
    {
        public bool Test()
        {
            var s = "aabbab";

            var expected = 0;

            var result = MinLengthAfterRemovals(s);

            Console.WriteLine(result);

            return result == expected;
        }
        public int MinLengthAfterRemovals(string s)
        {
            var na = 0;
            foreach (var c in s)
            {
                if (c == 'a')
                    na++;
            }

            return Math.Abs(s.Length - 2 * na);
        }

    }
}
