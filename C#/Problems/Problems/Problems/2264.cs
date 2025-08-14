using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2264 : IProblem
    {
        public bool Test()
        {
            var num = "6777133339";

            var expected = "777";

            var result = LargestGoodInteger(num);

            Console.WriteLine(result);

            return result == expected;
        }

        public string LargestGoodInteger(string num)
        {
            var result = string.Empty;
            for (int i = 2; i < num.Length; ++i)
            {
                if (num[i - 2] == num[i - 1] && num[i - 1] == num[i])
                {
                    if (num[i] == '9')
                        return "999";
                    if (result == string.Empty || num[i] > result[0])
                        result = new string(num[i], 3);
                }
            }

            return result;
        }
    }
}
