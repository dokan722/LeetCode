using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1209 : IProblem
    {
        public bool Test()
        {
            var s = "abcd";
            var k = 2;

            var expected = "abcd";

            var result = RemoveDuplicates(s, k);

            Console.WriteLine(result);

            return result == expected;
        }
        public string RemoveDuplicates(string s, int k)
        {
            var n = s.Length;
            var res = new Stack<(char C, int N)>();
            var start = 0;
            for (int i = 1; i < n; ++i)
            {
                if (s[i] != s[start])
                {
                    var l = i - start;
                    if (res.Count > 0 && res.Peek().C == s[start])
                        l += res.Pop().N;
                    var rem = l % k;
                    if (rem > 0)
                        res.Push((s[start], rem));
                    start = i;
                }
            }
            var ls = n - start;
            if (res.Count > 0 && res.Peek().C == s[start])
                ls += res.Pop().N;
            var rems = ls % k;
            if (rems > 0)
                res.Push((s[start], rems));
            var result = new StringBuilder();
            foreach (var c in res.Reverse())
                result.Append(new string(c.C, c.N));
            return result.ToString();
        }
    }
}
