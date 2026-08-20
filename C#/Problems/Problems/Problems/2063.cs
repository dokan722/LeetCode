using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2063 : IProblem
    {
        public bool Test()
        {
            var word = "aba";

            var expected = 6;

            var result = CountVowels(word);

            Console.WriteLine(result);

            return result == expected;
        }

        public long CountVowels(string word)
        {
            var n = word.Length;
            long result = 0;
            for (int i = 0; i < n; ++i)
            {
                var c = word[i];
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    long before = i + 1;
                    long after = n - i;
                    result += before * after;
                }
            }

            return result;
        }
    }
}
