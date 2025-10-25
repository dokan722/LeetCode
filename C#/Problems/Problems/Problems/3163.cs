using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3163 : IProblem
    {
        public bool Test()
        {
            var word = "aaaaaaaaaaaaaabb";

            var expected = "9a5a2b";

            var result = CompressedString(word);

            Console.WriteLine(result);

            return result == expected;
        }

        public string CompressedString(string word)
        {
            var n = word.Length;
            var start = 0;
            var curr = word[0];
            var result = new StringBuilder();
            for (int i = 1; i < n; i++)
            {
                if (curr != word[i])
                {
                    var l = i - start;
                    var full = l / 9;
                    var rest = l % 9;
                    result.Append(string.Concat(Enumerable.Repeat($"9{curr}", full)));
                    if (rest != 0)
                        result.Append($"{rest}{curr}");
                    curr = word[i];
                    start = i;
                }
            }
            var fl = n - start;
            var ffull = fl / 9;
            var frest = fl % 9;
            result.Append(string.Concat(Enumerable.Repeat($"9{curr}", ffull)));
            if (frest != 0)
                result.Append($"{frest}{curr}");

            return result.ToString();
        }
    }
}
