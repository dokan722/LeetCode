using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3084 : IProblem
    {
        public bool Test()
        {
            var s = "abada";
            var c = 'a';

            var expected = 6;

            var result = CountSubstrings(s, c);

            Console.WriteLine(result);

            return result == expected;
        }

        public long CountSubstrings(string s, char c)
        {
            int count = 1;
            long result = 0;
            foreach (var cr in s)
            {
                if (cr == c)
                {
                    result += count;
                    count++;
                }
            }

            return result;
        }
    }
}
