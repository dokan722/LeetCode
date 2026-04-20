using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2437 : IProblem
    {
        public bool Test()
        {
            var time = "?5:00";

            var expected = 2;

            var result = CountTime(time);

            Console.WriteLine(result);

            return result == expected;
        }

        public int CountTime(string time)
        {
            var result = 1;
            if (time[0] == '?')
            {
                if (time[1] == '?')
                    result *= 24;
                else
                {
                    if (time[1] < '4')
                        result *= 3;
                    else
                        result *= 2;
                }
            }
            else
            {
                if (time[1] == '?')
                {
                    if (time[0] == '2')
                        result *= 4;
                    else
                        result *= 10;
                }
            }
            if (time[3] == '?')
                result *= 6;
            if (time[4] == '?')
                result *= 10;

            return result;
        }
    }
}
