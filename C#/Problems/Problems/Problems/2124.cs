using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2124 : IProblem
    {
        public bool Test()
        {
            var s = "aaabbb";

            var expected = true;

            var result = CheckString(s);

            return expected == result;
        }

        public bool CheckString(string s)
        {
            var bs = s[0] == 'b';
            foreach (var c in s)
            {
                if (c == 'a' && bs)
                    return false;
                if (c == 'b')
                    bs = true;

            }

            return true;
        }
    }
}
