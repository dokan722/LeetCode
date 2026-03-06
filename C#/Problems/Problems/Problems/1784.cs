using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1784 : IProblem
    {
        public bool Test()
        {
            var s = "1001";

            var expected = false;

            var result = CheckOnesSegment(s);

            return expected == result;
        }

        public bool CheckOnesSegment(string s)
        {
            var n = s.Length;
            for (int i = n - 1; i > 0; --i)
            {
                if (s[i] == '1' && s[i - 1] == '0')
                    return false;
            }

            return true;
        }
    }
}
