using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _966 : IProblem
    {
        public bool Test()
        {
            var wordlist = new[] { "KiTe", "kite", "hare", "Hare" };
            var queries = new[] { "kite", "Kite", "KiTe", "Hare", "HARE", "Hear", "hear", "keti", "keet", "keto" };

            var expected = new[] { "kite", "KiTe", "KiTe", "Hare", "hare", "", "", "KiTe", "", "KiTe" };

            var result = Spellchecker(wordlist, queries);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(result, expected);
        }

        public string[] Spellchecker(string[] wordlist, string[] queries)
        {
            var exactMatches = new HashSet<string>();
            var caseMatches = new Dictionary<string, string>();
            var vowelMatches = new Dictionary<string, string>();
            foreach (var word in wordlist)
            {
                exactMatches.Add(word);
                caseMatches.TryAdd(word.ToLower(), word);
                vowelMatches.TryAdd(WildcardVowels(word), word);
            }

            var n = queries.Length;
            var result = new string[queries.Length];
            for (int i = 0; i < n; i++) 
            {
                if (exactMatches.Contains(queries[i]))
                    result[i] = queries[i];
                else if (caseMatches.ContainsKey(queries[i].ToLower()))
                    result[i] = caseMatches[queries[i].ToLower()];
                else if (vowelMatches.ContainsKey(WildcardVowels(queries[i])))
                    result[i] = vowelMatches[WildcardVowels(queries[i])];
                else
                    result[i] = "";
            }

            return result;
        }

        private string WildcardVowels(string word)
        {
            var result = "";
            foreach (var c in word.ToLower())
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                    result += '_';
                else
                    result += c;
            }

            return result;
        }
    }
}
