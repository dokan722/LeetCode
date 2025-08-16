using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1323 : IProblem
    {
        public bool Test()
        {
            var num = 9669;

            var expected = 9969;

            var result = Maximum69Number(num);

            Console.WriteLine(result);

            return expected == result;
        }

        public int Maximum69Number(int num)
        {
            var sNum = num.ToString();
            var n = sNum.Length;
            var found = false;
            for (int i = 0; i < n; ++i)
            {
                if (sNum[i] == '6')
                {
                    found = true;
                    sNum = sNum.Substring(0, i) + '9' + sNum.Substring(i + 1);
                    break;
                }
            }

            return found ? int.Parse(sNum) : num;
        }
    }
}
