using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1410 : IProblem
    {
        public bool Test()
        {
            var text = "&amp; is an HTML entity but &ambassador; is not.";

            var expected = "& is an HTML entity but &ambassador; is not.";

            var result = EntityParser(text);

            Console.WriteLine(result);

            return result == expected;
        }

        public string EntityParser(string text)
        {
            var encoded = new Dictionary<string, string>
            {
                {"quot", "\""},
                {"apos", "\'"},
                {"amp", "&"},
                {"gt", ">"},
                {"lt", "<"},
                {"frasl", "/"}
            };
            var n = text.Length;
            var result = new StringBuilder();
            for (int i = 0; i < n; ++i)
            {
                if (text[i] == '&' && i != n - 1)
                {
                    var start = i;
                    i++;
                    while (i < n && text[i] != ';' && text[i] != '&')
                        i++;
                    if (i == n)
                        result.Append(text.Substring(start));
                    else if (text[i] == '&')
                    {
                        result.Append(text.Substring(start, i - start));
                        i--;
                    }
                    else
                    {
                        var ins = text.Substring(start + 1, i - start - 1);
                        if (encoded.ContainsKey(ins))
                            result.Append(encoded[ins]);
                        else
                            result.Append(text.Substring(start, i - start + 1));
                    }
                }
                else
                    result.Append(text[i]);
            }
            return result.ToString();
        }
    }
}
