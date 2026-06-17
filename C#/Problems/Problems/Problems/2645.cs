using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2645 : IProblem
    {
        public bool Test()
        {
            var word = "b";

            var expected = 2;

            var result = AddMinimum(word);

            Console.WriteLine(result);

            return result == expected;
        }

        public int AddMinimum(string word)
        {
            var prev = 0;
            var result = 0;
            foreach (var c in word)
            {
                if (c == 'a')
                {
                    if (prev == 0)
                        prev++;
                    else if (prev == 1)
                        result += 2;
                    else
                    {
                        result++;
                        prev = 1;
                    }
                }
                else if (c == 'b')
                {
                    if (prev == 0)
                    {
                        result++;
                        prev = 2;
                    }
                    else if (prev == 1)
                        prev = 2;
                    else
                        result += 2;
                }
                else
                {
                    if (prev == 0)
                        result += 2;
                    else if (prev == 1)
                    {
                        result++;
                        prev = 0;
                    }
                    else
                        prev = 0;
                }
            }

            return result + 'c' - word[word.Length - 1];
        }
    }
}
