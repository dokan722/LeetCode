using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1455 : IProblem
    {
        public bool Test()
        {
            var sentence = "i love eating burger";
            var searchWord = "burg";

            var expected = 4;

            var result = IsPrefixOfWord(sentence, searchWord);

            Console.WriteLine(result);

            return result == expected;
        }

        public int IsPrefixOfWord(string sentence, string searchWord)
        {
            var words = sentence.Split(' ');
            var n = words.Length;
            var m = searchWord.Length;
            for (int i = 0; i < n; ++i)
            {
                if (words[i].Length < m)
                    continue;
                var valid = true;
                for (int j = 0; j < m; ++j)
                {
                    if (words[i][j] != searchWord[j])
                    {
                        valid = false;
                        break;
                    }
                }
                if (valid)
                    return i + 1;
            }

            return -1;
        }
    }
}
