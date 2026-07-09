using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1967 : IProblem
    {
        public bool Test()
        {
            var patterns = new[] { "a", "abc", "bc", "d" };
            var word = "abc";

            var expected = 3;

            var result = NumOfStrings(patterns, word);

            Console.WriteLine(result);

            return result == expected;
        }

        public int NumOfStrings(string[] patterns, string word)
        {
            var n = word.Length;
            var present = new HashSet<string>();
            var notPresent = new HashSet<string>();
            var result = 0;
            foreach (var p in patterns)
            {
                if (present.Contains(p))
                    result++;
                else if (!notPresent.Contains(p))
                {
                    var m = p.Length;
                    var prefs = new int[m];
                    var l = 0;
                    var d = 1;
                    while (d < m)
                    {
                        if (p[d] == p[l])
                        {
                            l++;
                            prefs[d] = l;
                            d++;
                        }
                        else
                        {
                            if (l != 0)
                                l = prefs[l - 1];
                            else
                            {
                                prefs[d] = 0;
                                d++;
                            }
                        }
                    }
                    l = 0;
                    d = 0;
                    while (d < n)
                    {
                        if (l == m)
                            break;
                        if (word[d] == p[l])
                        {
                            l++;
                            d++;
                        }
                        else if (l != 0)
                            l = prefs[l - 1];
                        else
                            d++;
                    }
                    if (l == m)
                    {
                        present.Add(p);
                        result++;
                    }
                    else
                        notPresent.Add(p);
                }
            }
            return result;
        }
    }
}
