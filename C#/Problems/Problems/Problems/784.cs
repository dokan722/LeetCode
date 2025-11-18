using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _784 : IProblem
    {
        public bool Test()
        {
            var s = "a1b2";

            var expected = new[] { "a1b2", "a1B2", "A1b2", "A1B2" };

            var result = LetterCasePermutation(s).ToArray();

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(result, expected);
        }

        public IList<string> LetterCasePermutation(string s)
        {
            var result = new List<string>() { "" };
            foreach (var c in s)
            {
                if (char.IsLetter(c))
                {
                    var newResult = new List<string>();
                    foreach (var word in result)
                    {
                        newResult.Add(word + char.ToLower(c));
                        newResult.Add(word + char.ToUpper(c));
                    }

                    result = newResult;
                }
                else
                {
                    var newResult = new List<string>();
                    foreach (var word in result)
                    {
                        newResult.Add(word + c);
                    }
                    result = newResult;
                }
            }

            return result;
        }
    }
}
