using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3360 : IProblem
    {
        public bool Test()
        {
            var n = 12;

            var expected = true;

            var result = CanAliceWin(n);

            return expected == result;
        }
        public bool CanAliceWin(int n)
        {
            for (int i = 10; i >= 0; --i)
            {
                if (n < i)
                    return i % 2 != 0;
                n -= i;
            }

            return true;
        }
    }
}
