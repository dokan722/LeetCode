using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3557 : IProblem
    {
        public bool Test()
        {
            var word = "abcdeafdef";

            var expected = 2;

            var result = MaxSubstrings(word);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MaxSubstrings(string word)
        {
            var n = word.Length;
            var last = new Dictionary<char, int>();
            var result = 0;
            for (int i = 0; i < n; ++i)
            {
                if (last.ContainsKey(word[i]))
                {
                    if (i - last[word[i]] >= 3)
                    {
                        result++;
                        last.Clear();
                    }
                }
                else
                    last[word[i]] = i;
            }
            return result;
        }
    }
}
