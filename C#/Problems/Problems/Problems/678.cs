using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _678 : IProblem
    {
        public bool Test()
        {
            var s = "(*))";

            var expected = true;

            var result = CheckValidString(s);

            return expected == result;
        }

        public bool CheckValidString(string s)
        {
            var maxDepth = 0;
            var minDepth = 0;
            foreach (var c in s)
            {
                if (c == '(')
                {
                    maxDepth++;
                    minDepth++;
                }
                else if (c == ')')
                {
                    maxDepth--;
                    minDepth--;
                }
                else
                {
                    maxDepth++;
                    minDepth--;
                }
                if (maxDepth < 0)
                    return false;
                minDepth = Math.Max(minDepth, 0);
            }

            return minDepth == 0;
        }
    }
}
