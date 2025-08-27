using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1910 : IProblem
    {
        public bool Test()
        {
            var s = "daabcbaabcbc";
            var part = "abc";

            var expected = "dab";

            var result = RemoveOccurrences(s, part);

            Console.WriteLine(result);

            return result == expected;
        }

        public string RemoveOccurrences(string s, string part)
        {
            var index = s.IndexOf(part);
            while (index != -1)
            {
                s = s.Substring(0, index) + s.Substring(index + part.Length);
                index = s.IndexOf(part);
            }

            return s;
        }
    }
}
