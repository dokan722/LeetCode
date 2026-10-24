using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2409 : IProblem
    {
        public bool Test()
        {
            var arriveAlice = "08-15";
            var leaveAlice = "08-18";
            var arriveBob = "08-16";
            var leaveBob = "08-19";

            var expected = 3;

            var result = CountDaysTogether(arriveAlice, leaveAlice, arriveBob, leaveBob);

            Console.WriteLine(result);

            return result == expected;
        }

        public int CountDaysTogether(string arriveAlice, string leaveAlice, string arriveBob, string leaveBob)
        {
            var aa = GetDays(arriveAlice);
            var la = GetDays(leaveAlice);
            var ab = GetDays(arriveBob);
            var lb = GetDays(leaveBob);

            var ts = Math.Max(aa, ab);
            var te = Math.Min(la, lb);

            return Math.Max(0, te - ts + 1);
        }

        private int GetDays(string date)
        {
            var days = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            var month = int.Parse(date.Substring(0, 2));
            var day = int.Parse(date.Substring(3, 2));
            var result = day;
            for (int i = 0; i < month - 1; ++i)
                result += days[i];
            return result;
        }
    }
}
