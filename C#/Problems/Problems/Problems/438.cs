using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _438 : IProblem
    {
        public bool Test()
        {
            var s = "cbaebabacd";
            var p = "abc";

            var expected = new[] { 0, 6 };

            var result = FindAnagrams(s, p);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }

        public IList<int> FindAnagrams(string s, string p)
        {
            var n = p.Length;
            var m = s.Length;
            var result = new List<int>();
            if (n > m)
                return result;
            var pattern = new int[26];
            foreach (var c in p)
                pattern[c - 'a']++;
            var cur = new int[26];
            for (int i = 0; i < n; ++i)
                cur[s[i] - 'a']++;
            var fine = true;
            for (int i = 0; i < 26; ++i)
            {
                if (pattern[i] != cur[i])
                {
                    fine = false;
                    break;
                }
            }
            if (fine)
                result.Add(0);
            for (int i = n; i < m; ++i)
            {
                fine = true;
                cur[s[i] - 'a']++;
                cur[s[i - n] - 'a']--;
                for (int j = 0; j < 26; ++j)
                {
                    if (pattern[j] != cur[j])
                    {
                        fine = false;
                        break;
                    }
                }
                if (fine)
                    result.Add(i - n + 1);
            }
            return result;
        }
    }
}
