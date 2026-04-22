using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2452 : IProblem
    {
        public bool Test()
        {
            var queries = new[] { "word", "note", "ants", "wood" };
            var dictionary = new[] { "wood", "joke", "moat" };

            var expected = new[] { "word", "note", "wood" };

            var result = TwoEditWords(queries, dictionary);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }

        public IList<string> TwoEditWords(string[] queries, string[] dictionary)
        {
            var n = dictionary.Length;
            var result = new List<string>();
            foreach (var query in queries)
            {
                var found = false;
                foreach (var word in dictionary)
                {
                    if (query.Length != word.Length)
                        continue;
                    var l = query.Length;
                    var diff = 0;
                    for (int i = 0; i < l && diff <= 2; ++i)
                    {
                        if (word[i] != query[i])
                            diff++;
                    }
                    if (diff <= 2)
                    {
                        found = true;
                        break;
                    }
                }
                if (found)
                    result.Add(query);
            }
            return result;
        }
    }
}
