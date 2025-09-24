using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3210 : IProblem
    {
        public bool Test()
        {
            var s = "dart";
            var k = 3;

            var expected = "tdar";

            var result = GetEncryptedString(s, k);

            Console.WriteLine(result);

            return result == expected;
        }

        public string GetEncryptedString(string s, int k)
        {
            var n = s.Length;
            var shift = (k % n);
            return s.Substring(shift) + s.Substring(0, shift);
        }
    }
}
