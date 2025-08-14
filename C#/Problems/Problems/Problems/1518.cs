using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1518 : IProblem
    {
        public bool Test()
        {
            var numBottles = 9;
            var numExchange = 3;

            var expected = 13;

            var result = NumWaterBottles(numBottles, numExchange);

            Console.WriteLine(result);

            return result == expected;
        }

        public int NumWaterBottles(int numBottles, int numExchange)
        {
            var result = 0;

            while (numBottles >= numExchange)
            {
                var newBottles = numBottles / numExchange;
                var remBottles = numBottles % numExchange;
                result += numBottles - remBottles;
                numBottles = remBottles + newBottles;
            }

            return result + numBottles;
        }
    }
}
