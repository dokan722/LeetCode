using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1758 : IProblem
    {
        public bool Test()
        {
            var s = "0100";

            var expected = 1;

            var result = MinOperations(s);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinOperations(string s)
        {
            var count = 0;
            var wantOne = true;
            foreach (var c in s)
            {
                if (wantOne)
                {
                    count += (c == '0' ? 1 : 0);
                    wantOne = false;
                }
                else
                {
                    count += (c == '0' ? 0 : 1);
                    wantOne = true;
                }
            }

            return Math.Min(count, s.Length - count);
        }
    }
}
