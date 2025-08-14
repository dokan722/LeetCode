using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3100 : IProblem
    {
        public bool Test()
        {
            var numBottles = 13;
            var numExchange = 6;

            var expected = 15;

            var result = MaxBottlesDrunk(numBottles, numExchange);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MaxBottlesDrunk(int numBottles, int numExchange)
        {
            var result = 0;

            while (numBottles >= numExchange)
            {
                numBottles -= numExchange;
                result += numExchange;
                numBottles++;
                numExchange++;
            }

            return result + numBottles;
        }
    }
}
