using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3760 : IProblem
    {
        public bool Test()
        {
            var s = "abab";

            var expected = 2;

            var result = MaxDistinct(s);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MaxDistinct(string s)
        {
            var seen = new bool[26];
            var result = 0;
            foreach (var c in s)
            {
                var id = c - 'a';
                if (!seen[id])
                    result++;
                seen[id] = true;
            }

            return result;
        }
    }
}
