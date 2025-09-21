using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1221 : IProblem
    {
        public bool Test()
        {
            var s = "RLRRLLRLRL";

            var expected = 4;

            var result = BalancedStringSplit(s);

            Console.WriteLine(result);

            return result == expected;
        }

        public int BalancedStringSplit(string s)
        {
            var ls = 0;
            var rs = 0;
            var result = 0;
            foreach (var c in s)
            {
                if (c == 'L')
                    ls++;
                else
                    rs++;
                if (ls == rs)
                {
                    result++;
                    ls = 0;
                    rs = 0;
                }
            }

            return result;
        }
    }
}
