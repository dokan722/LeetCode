using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3324 : IProblem
    {
        public bool Test()
        {
            var target = "abc";

            var expected = new[] { "a", "aa", "ab", "aba", "abb", "abc" };

            var result = StringSequence(target).ToArray();

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }

        public IList<string> StringSequence(string target)
        {
            var result = new List<string>();
            var curr = "";
            foreach (var c in target)
            {
                for (int i = 'a'; i <= c; ++i)
                {
                    result.Add(curr + (char)i);
                }

                curr += c;
            }

            return result;
        }
    }
}
