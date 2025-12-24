using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3271 : IProblem
    {
        public bool Test()
        {
            var s = "abcd";
            var k = 2;

            var expected = "bf";

            var result = StringHash(s, k);

            Console.WriteLine(result);

            return result == expected;
        }

        public string StringHash(string s, int k)
        {
            var n = s.Length;
            var hash = s[0] - 'a';
            var result = "";
            for (int i = 1; i < n; ++i)
            {
                if (i % k != 0)
                {
                    hash += s[i] - 'a';
                }
                else
                {
                    result += (char)('a' + hash % 26);
                    hash = s[i] - 'a';
                }
            }

            return result + (char)('a' + hash % 26);
        }
    }
}
