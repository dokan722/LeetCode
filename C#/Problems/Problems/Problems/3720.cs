using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3720 : IProblem
    {
        public bool Test()
        {
            var s = "abc";
            var target = "bba";

            var expected = "bca";

            var result = LexGreaterPermutation(s, target);

            Console.WriteLine(result);

            return result == expected;
        }

        public string LexGreaterPermutation(string s, string target)
        {
            var n = s.Length;
            var counts = new int[26];
            foreach (var c in s)
                counts[c - 'a']++;
            int i = 0;
            for (; i < n; ++i)
            {
                var id = target[i] - 'a';
                if (counts[id] > 0)
                    counts[id]--;
                else
                    break;
            }
            if (i != n)
                counts[target[i] - 'a']--;
            else
                i--;
            int j = 0;
            while (i >= 0)
            {
                counts[target[i] - 'a']++;
                var found = false;
                for (j = target[i] - 'a' + 1; j < 26; ++j)
                    if (counts[j] > 0)
                    {
                        found = true;
                        break;
                    }

                if (found)
                    break;
                i--;
            }
            if (i == -1)
                return string.Empty;
            counts[j]--;
            var result = new StringBuilder();
            result.Append(target.Substring(0, i));
            result.Append((char)(j + 'a'));
            for (i = 0; i < 26; ++i)
            for (j = 0; j < counts[i]; ++j)
                result.Append((char)(i + 'a'));

            return result.ToString();
        }
    }
}
