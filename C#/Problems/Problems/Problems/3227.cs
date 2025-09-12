using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3227 : IProblem
    {
        public bool Test()
        {
            var s = "leetcoder";

            var expected = true;

            var result = DoesAliceWin(s);

            return expected == result;
        }

        public bool DoesAliceWin(string s)
        {
            foreach (var c in s)
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                    return true;
            }

            return false;
        }
    }
}
