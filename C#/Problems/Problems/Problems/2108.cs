using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2108 : IProblem
    {
        public bool Test()
        {
            var words = new[] { "abc", "car", "ada", "racecar", "cool" };

            var expected = "ada";

            var result = FirstPalindrome(words);

            Console.WriteLine(result);

            return expected == result;
        }

        public string FirstPalindrome(string[] words)
        {
            foreach (var word in words)
            {
                var half = word.Length / 2;
                var isPal = true;
                for (int i = 0; i < half; i++)
                {
                    if (word[i] != word[^(i + 1)])
                    {
                        isPal = false;
                        break;
                    }
                }
                if (isPal)
                    return word;
            }

            return "";
        }
    }
}
