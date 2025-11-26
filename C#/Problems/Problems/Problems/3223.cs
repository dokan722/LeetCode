using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3223 : IProblem
    {
        public bool Test()
        {
            var s = "abaacbcbb";

            var expected = 5;

            var result = MinimumLength(s);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinimumLength(string s)
        {
            var counts = new int[26];
            foreach (char c in s)
            {
                counts[c - 'a']++;
            }

            var result = 0;
            foreach (int count in counts)
            {
                if (count > 0)
                    result += 1 + (count % 2 == 0 ? 1 : 0);
            }

            return result;
        }
    }
}
