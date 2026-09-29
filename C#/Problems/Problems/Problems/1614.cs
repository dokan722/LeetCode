using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1614 : IProblem
    {
        public bool Test()
        {
            var s = "(1+(2*3)+((8)/4))+1";

            var expected = 3;

            var result = MaxDepth(s);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MaxDepth(string s)
        {
            var d = 0;
            var result = 0;
            foreach (var c in s)
            {
                if (c == '(')
                {
                    d++;
                    result = Math.Max(result, d);
                }
                else if (c == ')')
                    d--;
            }

            return result;
        }
    }
}
