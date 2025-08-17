using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3039 : IProblem
    {
        public bool Test()
        {
            var s = "aabcbbca";

            var expected = "ba";

            var result = LastNonEmptyString(s);

            Console.WriteLine(result);

            return expected == result;
        }

        public string LastNonEmptyString(string s)
        {
            var counts = new int[26];
            var lastIds = new int[26];
            for (int i = 0; i < s.Length; i++)
            {
                counts[s[i] - 'a']++;
                lastIds[s[i] - 'a'] = i;
            }

            var maxCount = 0;
            foreach (var count in counts)
            {
                if (count > maxCount)
                    maxCount = count;
            }

            var remainingLetters = new List<(int Id, char Letter)>();
            for (int i = 0; i < 26; ++i)
            {
                if (counts[i] == maxCount)
                    remainingLetters.Add((lastIds[i], (char)(i + 'a')));
            }
            var result = new StringBuilder();
            foreach (var letter in remainingLetters.OrderBy(x => x.Id))
            {
                result.Append(letter.Letter);
            }

            return result.ToString();
        }
    }
}
