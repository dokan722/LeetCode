using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1839 : IProblem
    {
        public bool Test()
        {
            var word = "aeiaaioaaaaeiiiiouuuooaauuaeiu";

            var expected = 13;

            var result = LongestBeautifulSubstring(word);

            Console.WriteLine(result);

            return result == expected;
        }

        public int LongestBeautifulSubstring(string word)
        {
            var maxLen = 0;
            var nextReq = -1;
            var l = 0;
            var vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            foreach (var c in word)
            {
                if (c == 'u' && nextReq == 4)
                {
                    l++;
                    if (l > maxLen)
                        maxLen = l;
                }
                else if (nextReq != -1 && c == vowels[nextReq])
                {
                    l++;
                }
                else if (nextReq < 4 && c == vowels[nextReq + 1])
                {
                    l++;
                    nextReq++;
                    if (c == 'u' && nextReq == 4)
                    {
                        if (l > maxLen)
                            maxLen = l;
                    }
                }
                else
                {
                    nextReq = -1;
                    l = 0;
                    if (c == 'a')
                    {
                        nextReq++;
                        l++;
                    }
                }
            }

            return maxLen;
        }
    }
}
