using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1432 : IProblem
    {
        public bool Test()
        {
            var num = 123456;


            var expected = 820000;

            var result = MaxDiff(num);

            Console.WriteLine(result);

            return expected == result;
        }

        public int MaxDiff(int num)
        {
            var numsString = num.ToString();
            var charArr = numsString.ToCharArray();

            var swapToMin = charArr.FirstOrDefault(x => x != '1' && x != '0').ToString();
            var swapToMax = charArr.FirstOrDefault(x => x != '9').ToString();

            var min = swapToMin == "\0" ? numsString : numsString.Replace(swapToMin, swapToMin == numsString[0].ToString() ? "1" : "0");
            var max = swapToMax == "\0" ? numsString : numsString.Replace(swapToMax, "9");

            return int.Parse(max) - int.Parse(min);
        }
    }
}
