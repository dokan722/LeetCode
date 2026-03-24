using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2185 : IProblem
    {
        public bool Test()
        {
            var words = new[] { "pay", "attention", "practice", "attend" };
            var pref = "at";

            var expected = 2;

            var result = PrefixCount(words, pref);

            Console.WriteLine(result);

            return result == expected;
        }

        public int PrefixCount(string[] words, string pref)
        {
            var n = pref.Length;
            var result = 0;
            foreach (var word in words)
            {
                if (word.Length >= n && pref == word.Substring(0, n))
                    result++;
            }

            return result;
        }
    }
}
