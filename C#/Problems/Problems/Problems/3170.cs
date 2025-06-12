using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Problems.Problems
{
    public class _3170 : IProblem
    {
        public bool Test()
        {
            var s = "aaba*";

            var expected = "aab";

            var result = ClearStars(s);

            Console.Write(result);

            return expected == result;
        }

        public string ClearStars(string s)
        {
            Stack<int>[] letterIndexes = new Stack<int>[26];
            for (int i = 0; i < 26; ++i)
            {
                letterIndexes[i] = new Stack<int>();
            }
            var sArr = s.ToCharArray();
            for (int i = 0; i < s.Length; ++i)
            {
                if (s[i] == '*')
                {
                    for (int j = 0; j < 26; j++)
                    {
                        if (letterIndexes[j].Count > 0)
                        {
                            sArr[letterIndexes[j].Pop()] = '*';
                            break;
                        }
                    }
                }
                else
                {
                    letterIndexes[s[i] - 'a'].Push(i);
                }
            }
            var sb = new StringBuilder();

            for (int i = 0; i < s.Length; ++i)
            {
                if (sArr[i] == '*')
                {
                    continue;
                }
                sb.Append(sArr[i]);
            }

            return sb.ToString();
        }
    }
}
