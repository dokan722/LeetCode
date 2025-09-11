using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2785 : IProblem
    {
        public bool Test()
        {
            var s = "lEetcOde";

            var expected = "lEOtcede";

            var result = SortVowels(s);

            Console.WriteLine(result);

            return result == expected;
        }

        public string SortVowels(string s)
        {
            var vowelsDic = new Dictionary<char, int>()
            {
                {'A', 0},
                {'E', 0},
                {'I', 0},
                {'O', 0},
                {'U', 0},
                {'a', 0},
                {'e', 0},
                {'i', 0},
                {'o', 0},
                {'u', 0},
            };
            foreach (var c in s)
                if (IsVowel(c))
                    vowelsDic[c]++;

            var p = 0;
            var result = s.ToCharArray();
            foreach (var vowel in vowelsDic)
            {
                for (int i = 0; i < vowel.Value; ++i)
                {
                    while (!IsVowel(s[p]))
                        p++;
                    result[p] = vowel.Key;
                    p++;
                }
            }

            return string.Join("", result);
        }

        private bool IsVowel(char c)
        {
            c = char.ToLower(c);
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                return true;
            return false;
        }
    }
}
