using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1513 : IProblem
    {
        public bool Test()
        {
            var s = "0110111";

            var expected = 9;

            var result = NumSub(s);

            Console.WriteLine(result);

            return result == expected;
        }

        public int NumSub(string s)
        {
            var n = s.Length;
            var result = 0;
            var mod = 1000000007;
            for (int i = 0; i < n; ++i)
            {
                if (s[i] == '1')
                {
                    var start = i;
                    while (i < n && s[i] ==  '1')
                        ++i;
                    long l = i - start;
                    result += (int)(l * (l + 1) / 2 % mod);
                }
            }

            return result;
        }
    }
}
