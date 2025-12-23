using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _890 : IProblem
    {
        public bool Test()
        {
            var words = new[] { "abc", "deq", "mee", "aqq", "dkd", "ccc" };
            var pattern = "abb";

            var expected = new[] { "mee", "aqq" };

            var result = FindAndReplacePattern(words, pattern).ToArray();

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }

        public IList<string> FindAndReplacePattern(string[] words, string pattern)
        {
            var result = new List<string>();
            var ep = Encode(pattern);
            foreach (var word in words)
            {
                if (ep == Encode(word))
                    result.Add(word);
            }

            return result;
        }

        private string Encode(string word)
        {
            char num = '0';
            var result = "";
            var map = new Dictionary<char, char>();
            foreach (var c in word)
            {
                if (!map.ContainsKey(c))
                {
                    map[c] = num;
                    num++;
                }

                result += map[c];
            }

            return result;
        }
    }
}
