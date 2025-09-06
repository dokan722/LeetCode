using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1807 : IProblem
    {
        public bool Test()
        {
            var s = "(name)is(age)yearsold";
            var knowledge = new List<IList<string>> { new List<string> { "name", "bob" }, new List<string> { "age", "two" } };

            var expected = "bobistwoyearsold";

            var result = Evaluate(s, knowledge);

            Console.WriteLine(result);

            return expected == result;
        }

        public string Evaluate(string s, IList<IList<string>> knowledge)
        {
            var wordsDic = knowledge.ToDictionary(x => x[0], x => x[1]);
            var result = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    var start = i + 1;
                    var end = start + 1;
                    while (s[end] != ')')
                        end++;
                    var key = s.Substring(start, end - start);
                    if (wordsDic.ContainsKey(key))
                        result.Append(wordsDic[key]);
                    else
                        result.Append('?');
                    i = end;
                }
                else
                    result.Append(s[i]);
            }

            return result.ToString();
        }
    }
}
