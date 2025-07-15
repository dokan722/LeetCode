using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3136 : IProblem
    {
        public bool Test()
        {
            var word = "234Adas";

            var expected = true;

            var result = IsValid(word);

            return expected == result;
        }


        public bool IsValid(string word)
        {
            if (word.Length < 3)
                return false;
            var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };
            var haveVowel = false;
            var haveCons = false;
            foreach (var c in word)
            {
                if (vowels.Contains(char.ToLower(c)))
                    haveVowel = true;
                else if (char.IsLetter(c))
                    haveCons = true;
                else if (!char.IsDigit(c))
                    return false;
            }

            return haveCons && haveVowel;
        }
    }
}
