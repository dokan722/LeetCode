using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1625 : IProblem
    {
        public bool Test()
        {
            var s = "5525";
            var a = 9;
            var b = 2;

            var expected = "2050";

            var result = FindLexSmallestString(s, a, b);

            Console.WriteLine(result);

            return expected == result;
        }
        public string FindLexSmallestString(string s, int a, int b)
        {
            var present = new SortedSet<string>();
            FindRec(s, a, b, present);

            return present.First();
        }

        private void FindRec(string s, int a, int b, SortedSet<string> present)
        {
            if (present.Contains(s))
                return;
            present.Add(s);

            var n = s.Length;
            var added = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                    added.Append(s[i]);
                else
                    added.Append((char)('0' + (s[i] - '0' + a) % 10));
            }

            var rotated = s.Substring(n - b, b) + s.Substring(0, n - b);
            FindRec(added.ToString(), a, b, present);
            FindRec(rotated, a, b, present);
        }
    }
}
