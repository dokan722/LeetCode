using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _904 : IProblem
    {
        public bool Test()
        {
            var fruits = new[] { 1,0,1,4,1,4,1,2,3 };

            var expected = 5;

            var result = TotalFruit(fruits);

            Console.WriteLine(result);

            return expected == result;
        }

        public int TotalFruit(int[] fruits)
        {
            var n = fruits.Length;
            var start = 0;
            
            while (start < n && fruits[start] == fruits[0])
                start++;
            if (start >= n)
                return n;

            var firstFruit = fruits[0];
            var firstCount = start;
            int secondFruit = fruits[start];
            var secondCount = 1;

            var lastSwap = start;
            var result = 0;
            var prev = fruits[start];

            for (int i = start + 1; i < n; ++i)
            {
                if (fruits[i] != firstFruit && fruits[i] != secondFruit)
                {
                    if (firstCount + secondCount > result)
                        result = firstCount + secondCount;
                    if (fruits[i - 1] == firstFruit)
                    {
                        secondFruit = fruits[i];
                        secondCount = 1;
                        firstCount = i - lastSwap;
                    }
                    else
                    {
                        firstFruit = fruits[i];
                        firstCount = 1;
                        secondCount = i - lastSwap;
                    }

                }
                else if (fruits[i] == firstFruit)
                    firstCount++;
                else
                    secondCount++;

                if (fruits[i] != prev)
                {
                    prev = fruits[i];
                    lastSwap = i;
                }
            }

            if (firstCount + secondCount > result)
                result = firstCount + secondCount;

            return result;
        }
    }
}
