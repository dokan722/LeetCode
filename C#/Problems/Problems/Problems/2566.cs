using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2566 : IProblem
    {
        public bool Test()
        {
            var num = 11891;


            var expected = 99009;

            var result = MinMaxDifference(num);

            Console.WriteLine(result);

            return expected == result;
        }

        public int MinMaxDifference(int num)
        {
            var numsString = num.ToString();
            var charArr = numsString.ToCharArray();

            var swapToMin = charArr.First().ToString();
            var swapToMax = charArr.FirstOrDefault(x => x != '9').ToString();

            var min = swapToMin == "0" ? numsString : numsString.Replace(swapToMin, "0");
            var max = swapToMax == null ? numsString : numsString.Replace(swapToMax, "9");

            return int.Parse(max) - int.Parse(min);
        }
    }
}
