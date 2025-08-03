using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2106 : IProblem
    {
        public bool Test()
        {
            //var fruits = new[] { new[] {0, 9}, new[] {4, 1}, new[] {5, 7}, new[] {6, 2}, new[] {7, 4}, new[] {10, 9}};
            var fruits = new[] { new[] { 2, 8 }, new[] { 6, 3 }, new[] { 8, 6 }};
            var startPos = 5;
            var k = 4;

            var expected = 14;

            var result = MaxTotalFruits(fruits, startPos, k);

            Console.WriteLine(result);

            return result == expected;
        }


        //doest work w/e stupid edge cases
        public int MaxTotalFruits(int[][] fruits, int startPos, int k)
        {
            var n = fruits.Length;
            var left = CurrFruitId(fruits, 0, n, startPos);
            var right = left;
            var prefixSum = new int[n + 2];
            prefixSum[0] = 0;
            for (int i = 0; i < n; ++i)
                prefixSum[i + 1] = prefixSum[i] + fruits[i][1];
            prefixSum[^1] = prefixSum[^2];

            while (left > 0 && startPos - fruits[left - 1][0] <= k)
                left--;

            if (left == right && (right >= n || fruits[right][0] - startPos > k))
                return 0;


            right--;
            var traveled = (startPos - fruits[left][0]) * 2;
            while (right < n - 1 && fruits[right + 1][0] - startPos <= (k - traveled))
                right++;

            var sum = prefixSum[right + 1] - prefixSum[left];
            if (right >= n)
                return sum;

            var result = sum;
            while (right < n - 1 && fruits[right][0] - startPos <= k)
            {
                var freeSteps = k - (Math.Max(fruits[right][0], startPos) - Math.Min(fruits[left][0], startPos)) * 2;
                var stepsNeeded = (fruits[right + 1][0] - fruits[right][0]) - freeSteps;
                if (stepsNeeded > 0)
                {
                    var newLeft = CurrFruitId(fruits, left, right + 1, fruits[left][0] + stepsNeeded);
                    sum -= prefixSum[newLeft] - prefixSum[left];

                }
                sum += fruits[right + 1][1];
                right++;
                if (sum > result)
                    result = sum;
            }


            return result;
        }

        private int CurrFruitId(int[][] fruits, int left, int right, int value)
        {
            while (left < right)
            {
                var mid = (left + right) / 2;
                if (fruits[mid][0] < value)
                    left = mid + 1;
                else
                    right = mid;
            }

            return left;
        }
    }
}
