using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2651 : IProblem
    {
        public bool Test()
        {
            var arrivalTime = 15;
            var delayedTime = 5;

            var expected = 20;

            var result = FindDelayedArrivalTime(arrivalTime, delayedTime);

            Console.WriteLine(result);

            return result == expected;
        }

        public int FindDelayedArrivalTime(int arrivalTime, int delayedTime)
        {
            return (arrivalTime + delayedTime) % 24;
        }
    }
}
