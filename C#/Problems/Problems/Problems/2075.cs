using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2075 : IProblem
    {
        public bool Test()
        {
            var encodedText = "ch   ie   pr";
            var rows = 3;

            var expected = "cipher";

            var result = DecodeCiphertext(encodedText, rows);

            Console.WriteLine(result);  

            return result == expected;
        }

        public string DecodeCiphertext(string encodedText, int rows)
        {
            if (rows == 1)
                return encodedText;
            var resultb = new StringBuilder();
            var rl = encodedText.Length / rows;
            for (int i = 0; i < rl; ++i)
            {
                var full = true;
                var col = i;
                for (int j = 0; j < rows; ++j)
                {
                    if (col + j >= rl)
                    {
                        full = false;
                        break;
                    }
                    resultb.Append(encodedText[j * rl + j + col]);
                }
                if (full == false)
                    break;
            }
            var result = resultb.ToString();
            var m = result.Length - 1;
            while (m >= 0 && result[m] == ' ')
                m--;
            return result.Substring(0, m + 1);
        }
    }
}
