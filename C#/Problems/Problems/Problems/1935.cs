using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1935 : IProblem
    {
        public bool Test()
        {
            var text = "hello world";
            var brokenLetters = "ad";

            var expected = 1;

            var result = CanBeTypedWords(text, brokenLetters);

            Console.WriteLine(result);

            return result == expected;
        }

        public int CanBeTypedWords(string text, string brokenLetters)
        {
            var lettersSet = new HashSet<char>();
            foreach (var letter in brokenLetters)
                lettersSet.Add(letter);

            var words = 1;
            var brokenWords = 0;
            var canWrite = true;
            foreach (var c in text)
            {
                if (c == ' ')
                {
                    words++;
                    canWrite = true;
                    continue;
                }

                if (canWrite && lettersSet.Contains(c))
                {
                    brokenWords++;
                    canWrite = false;
                }
            }
            return words - brokenWords;
        }
    }
}
