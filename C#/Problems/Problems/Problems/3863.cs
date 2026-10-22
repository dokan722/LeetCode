using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3863 : IProblem
    {
        public bool Test()
        {
            var s = "dog";

            var expected = 1;

            var result = MinOperations(s);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinOperations(string s)
        {
            var n = s.Length;
            if (n == 1)
                return 0;
            if (n == 2)
            {
                return s[0] <= s[1] ? 0 : -1;
            }
            var counts = new int[26];
            counts[s[0] - 'a']++;
            var sorted = true;
            for (int i = 1; i < n; ++i)
            {
                counts[s[i] - 'a']++;
                if (s[i] < s[i - 1])
                    sorted = false;
            }
            if (sorted)
                return 0;
            var mn = (int)'a';
            var mx = (int)'a';
            for (int i = 0; i < 26; ++i)
            {
                if (counts[i] != 0)
                {
                    mn += i;
                    break;
                }
            }
            for (int i = 25; i >= 0; --i)
            {
                if (counts[i] != 0)
                {
                    mx += i;
                    break;
                }
            }
            if (mn == mx)
                return 0;
            if (s[0] == mn || s[n - 1] == mx)
                return 1;
            if (s[0] == mx && s[n - 1] == mn && counts[mx - 'a'] == 1 && counts[mn - 'a'] == 1)
                return 3;
            return 2;
        }
    }
}
