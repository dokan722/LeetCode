using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2486 : IProblem
    {
        public bool Test()
        {
            var s = "coaching";
            var t = "coding";

            var expected = 4;

            var result = AppendCharacters(s, t);

            Console.WriteLine(result);

            return result == expected;
        }

        public int AppendCharacters(string s, string t)
        {
            var p = 0;
            foreach (var c in s)
            {
                if (t[p] == c)
                {
                    p++;
                    if (p == t.Length)
                        return 0;
                }
            }

            return t.Length - p;
        }
    }
}
