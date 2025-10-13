using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2273 : IProblem
    {
        public bool Test()
        {
            var words = new[] { "abba", "baba", "bbaa", "cd", "cd" };

            var expected = new[] { "abba", "cd" };

            var result = RemoveAnagrams(words);

            Utils.Print1DArray(result.ToArray());

            return Utils.Compare1DArrays(result.ToArray(), expected);
        }
        public IList<string> RemoveAnagrams(string[] words)
        {
            var result = new List<string>() { words[0] };
            var current = words[0].ToCharArray();
            Array.Sort(current);
            foreach (var word in words)
            {
                var sorted = word.ToCharArray();
                Array.Sort(sorted);
                if (sorted.SequenceEqual(current))
                    continue;
                result.Add(word);
                current = sorted;
            }


            return result;
        }
    }
}
