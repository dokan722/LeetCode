using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1904 : IProblem
    {
        public bool Test()
        {
            var loginTime = "09:31";
            var logoutTime = "10:14";

            var expected = 1;

            var result = NumberOfRounds(loginTime, logoutTime);

            Console.WriteLine(result);

            return result == expected;
        }

        public int NumberOfRounds(string loginTime, string logoutTime)
        {
            var inTs = int.Parse(loginTime.Substring(0, 2)) * 60 + int.Parse(loginTime.Substring(3, 2));
            var outTs = int.Parse(logoutTime.Substring(0, 2)) * 60 + int.Parse(logoutTime.Substring(3, 2));
            var first = (inTs + 14) / 15;
            var last = outTs / 15;
            if (inTs < outTs && first > last)
                return 0;

            return first <= last ? last - first : (4 * 24) - first + last;
        }
    }
}
