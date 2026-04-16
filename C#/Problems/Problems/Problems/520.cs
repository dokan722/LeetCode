using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _520 : IProblem
    {
        public bool Test()
        {
            var word = "USA";

            var expected = true;

            var result = DetectCapitalUse(word);

            Console.WriteLine(result);

            return result == expected;
        }

        public bool DetectCapitalUse(string word)
        {
            var n = word.Length;
            if (n == 1)
                return true;
            bool big = word[1] < 'a';
            if (big && word[0] >= 'a')
                return false;
            for (int i = 2; i < n; ++i)
                if (big != word[i] < 'a')
                    return false;

            return true;
        }
    }
}
