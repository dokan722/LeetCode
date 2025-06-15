using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _12 : IProblem
    {
        public bool Test()
        {
            var num = 3749;


            var expected = "MMMDCCXLIX";

            var result = IntToRoman(num);

            Console.WriteLine(result);

            return expected == result;
        }

        public string IntToRoman(int num)
        {
            var numString = num.ToString();
            var result = new StringBuilder();

            if (numString.Length == 4)
            {
                result.Append(new string('M', numString[0] - '0'));
                numString = numString.Substring(1);
            }


            if (numString.Length == 3)
            {
                AppendStuff(result, 'C', 'D', 'M', numString[0]);
                numString = numString.Substring(1);
            }

            if (numString.Length == 2)
            {
                AppendStuff(result, 'X', 'L', 'C', numString[0]);
                numString = numString.Substring(1);
            }

            if (numString.Length == 1)
            {
                AppendStuff(result, 'I', 'V', 'X', numString[0]);
                numString = numString.Substring(1);
            }


            return result.ToString();
        }

        private void AppendStuff(StringBuilder result, char one, char five, char dec, char src)
        {
            if (src < '4')
                result.Append(new string(one, src - '0'));
            else if (src == '4')
                result.Append(string.Concat(one, five));
            else if (src < '9')
                result.Append(string.Concat(five,  new string(one, src - '0' - 5)));
            else
                result.Append(string.Concat(one, dec));
        }
    }
}
