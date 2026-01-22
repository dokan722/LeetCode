using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3675 : IProblem
    {
        public bool Test()
        {
            var s = "yz";

            var expected = 2;

            var result = MinOperations(s);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinOperations(string s)
        {
            var present = new bool[26];
            foreach (var c in s)
            {
                present[c - 'a'] = true;
            }
            var prev = -1;
            var result = 0;
            for (int i = 1; i < 26; ++i)
            {
                if (present[i])
                {
                    if (prev == -1)
                        prev = i;
                    else
                    {
                        result += i - prev;
                        prev = i;
                    }
                }
            }

            return result + (prev != -1 ? 26 - prev : 0);
        }
    }
}
