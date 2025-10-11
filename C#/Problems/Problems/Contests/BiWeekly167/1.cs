using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problems.Problems;

namespace Problems.Contests.BiWeekly167
{
    public class _1 : IProblem
    {
        public bool Test()
        {
            var s = "adcb";
            var expected = true;
            var result = ScoreBalance(s);

            return expected == result;
        }

        public bool ScoreBalance(string s)
        {
            var sum = 0;
            foreach (var c in s)
                sum += c - 'a' + 1;
            if (sum % 2 != 0)
                return false;
            var currSum = 0;
            foreach (var c in s)
            {
                currSum += c - 'a' + 1;
                sum -= c - 'a' + 1;
                if (currSum == sum)
                    return true;
            }

            return false;
        }
    }
}
