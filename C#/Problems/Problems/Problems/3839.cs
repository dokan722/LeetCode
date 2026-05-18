using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3839 : IProblem
    {
        public bool Test()
        {
            var words = new[] { "apple", "apply", "banana", "bandit" };
            var k = 2;

            var expected = 2;

            var result = PrefixConnected(words, k);

            Console.WriteLine(result);

            return result == expected;
        }

        public int PrefixConnected(string[] words, int k)
        {
            var result = 0;
            var groups = new Dictionary<string, int>();
            foreach (var word in words)
            {
                if (word.Length < k)
                    continue;
                var pref = word.Substring(0, k);
                if (groups.ContainsKey(pref))
                {
                    if (groups[pref] == 1)
                        result++;
                    groups[pref]++;
                }
                else
                    groups[pref] = 1;
            }

            return result;
        }
    }
}
