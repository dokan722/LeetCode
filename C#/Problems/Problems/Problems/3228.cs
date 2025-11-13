using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3228 : IProblem
    {
        public bool Test()
        {
            var s = "1001101";

            var expected = 4;

            var result = MaxOperations(s);

            Console.WriteLine(result);
            
            return result == expected;
        }

        public int MaxOperations(string s)
        {
            var n = s. Length;
            var result = 0;
            var ones = 0;
            for (int i = 0; i < n; ++i)
            {
                if (s[i] == '1')
                {
                    while (i < n && s[i] == '1')
                    {
                        ones++;
                        i++;
                    }
                    if (i < n)
                        result += ones;
                }
            }
            return result;
        }
    }
}
