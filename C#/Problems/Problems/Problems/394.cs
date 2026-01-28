using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _394 : IProblem
    {
        public bool Test()
        {
            var s = "3[a]2[bc]";

            var expected = "aaabcbc";

            var result = DecodeString(s);

            Console.WriteLine(result);

            return result == expected;
        }

        public string DecodeString(string s)
        {
            var i = 0;
            return Decode(s, ref i);
        }

        public string Decode(string s, ref int i)
        {
            var result = new StringBuilder();
            string phrase = "";
            var nums = 0;
            while (i < s.Length)
            {
                if (char.IsDigit(s[i]))
                {
                    nums = nums * 10 + (s[i] - '0');
                    ++i;
                }
                else if (s[i] == '[')
                {
                    ++i;
                    phrase = Decode(s, ref i);
                    for (int j = 0; j < nums; ++j)
                        result.Append(phrase);
                    nums = 0;
                }
                else if (s[i] == ']')
                {
                    ++i;
                    return result.ToString();
                }
                else
                {
                    result.Append(s[i]);
                    ++i;
                }
            }

            return result.ToString();
        }
    }
}
