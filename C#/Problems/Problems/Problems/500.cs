using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _500 : IProblem
    {
        public bool Test()
        {
            var words = new[] { "Hello", "Alaska", "Dad", "Peace" };

            var expected = new[] { "Alaska", "Dad" };

            var result = FindWords(words);

            return result.SequenceEqual(expected);
        }

        public string[] FindWords(string[] words)
        {
            var dic = new Dictionary<char, int>();
            foreach (var c in "qwertyuiop")
                dic[c] = 0;
            foreach (var c in "asdfghjkl")
                dic[c] = 1;
            foreach (var c in "zxcvbnm")
                dic[c] = 2;
            var result = new List<string>();

            foreach (var word in words)
            {
                var eh = word.ToLower();
                var row = dic[eh[0]];
                var oneRow = true;
                foreach (var c in eh.Skip(1))
                {
                    if (dic[c] != row)
                    {
                        oneRow = false;
                        break;
                    }
                }
                if (oneRow)
                    result.Add(word);
            }

            return result.ToArray();
        }
    }
}
