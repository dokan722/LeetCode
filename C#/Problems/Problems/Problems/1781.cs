using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1781 : IProblem
    {
        public bool Test()
        {
            var s = "aabcbaa";

            var expected = 17;

            var result = BeautySum(s);

            Console.WriteLine(result);

            return result == expected;
        }

        public int BeautySum(string s)
        {
            var n = s.Length;
            var result = 0;
            for (int i = 0; i < n; ++i)
            {
                var freq = new int[26];
                for (int j = i; j < n; ++j)
                {
                    var top = 0;
                    var bot = 2137;
                    var id = s[j] - 'a';
                    freq[id]++;
                    for (int k = 0; k < 26; ++k)
                    {
                        if (freq[k] == 0)
                            continue;
                        top = Math.Max(top, freq[k]);
                        bot = Math.Min(bot, freq[k]);
                    }

                    if (bot != 2137)
                        result += top - bot;
                }
            }

            return result;
        }
    }
}
