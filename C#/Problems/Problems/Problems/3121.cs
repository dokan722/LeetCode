using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3121 : IProblem
    {
        public bool Test()
        {
            var word = "aaAbcBC";

            var expected = 3;

            var result = NumberOfSpecialChars(word);

            Console.WriteLine(result);

            return result == expected;
        }

        public int NumberOfSpecialChars(string word)
        {
            var n = word.Length;
            var lowers = new int[26];
            var uppers = new int[26];
            for (int i = 0; i < n; ++i)
            {
                var upper = word[i] <= 'Z';
                var id = upper ? word[i] - 'A' : word[i] - 'a';
                if (upper)
                {
                    if (uppers[id] == 0)
                        uppers[id] = i + 1;
                }
                else
                    lowers[id] = i + 1;
            }
            var result = 0;
            for (int i = 0; i < 26; ++i)
            {
                if (lowers[i] > 0 && uppers[i] > lowers[i])
                    result++;
            }
            return result;
        }
    }
}
