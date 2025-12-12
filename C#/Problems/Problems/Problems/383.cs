using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _383 : IProblem
    {
        public bool Test()
        {
            var ransomNote = "a";
            var magazine = "b";

            var expected = false;

            var result = CanConstruct(ransomNote, magazine);

            return expected == result;
        }

        public bool CanConstruct(string ransomNote, string magazine)
        {
            var ransomCount = new int[26];
            var magazineCount = new int[26];
            foreach (var c in ransomNote)
                ransomCount[c - 'a']++;
            foreach (var c in magazine)
                magazineCount[c - 'a']++;
            for (int i = 0; i < 26; ++i)
            {
                if (ransomCount[i] > magazineCount[i])
                    return false;
            }

            return true;
        }
    }
}
