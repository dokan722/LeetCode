using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3330 : IProblem
    {
        public bool Test()
        {
            var word = "abbcccc";

            var expected = 5;

            var result = PossibleStringCount(word);

            Console.WriteLine(result);

            return result == expected;
        }

        public int PossibleStringCount(string word)
        {
            var len = 1;
            var prev = word[0];
            var result = 1;
            for (int i = 1; i < word.Length; i++)
            {
                if (prev != word[i])
                {
                    result += (len - 1);
                    len = 1;
                    prev = word[i];
                }
                else
                    len++;
            }

            result += (len - 1);

            return result;
        }
    }
}
