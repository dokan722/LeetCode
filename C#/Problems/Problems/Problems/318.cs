using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _318 : IProblem
    {
        public bool Test()
        {
            var words = new[] { "abcw", "baz", "foo", "bar", "xtfn", "abcdef" };

            var expected = 16;

            var result = MaxProduct(words);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MaxProduct(string[] words)
        {
            var n = words.Length;
            var result = 0;
            var masks = new int[n];
            for (int i = 0; i < n; ++i)
            {
                var mask = 0;
                foreach (var c in words[i])
                    mask |= 1 << (c - 'a');
                masks[i] = mask;
            }
            for (int i = 0; i < n; ++i)
            {

                for (int j = i + 1; j < n; ++j)
                {
                    if ((masks[i] & masks[j]) == 0)
                    {
                        result = Math.Max(result, words[i].Length * words[j].Length);
                    }
                }
            }

            return result;
        }
    }
}
