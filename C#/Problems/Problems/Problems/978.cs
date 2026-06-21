using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _978 : IProblem
    {
        public bool Test()
        {
            var arr = new[] { 9, 4, 2, 10, 7, 8, 8, 1, 9 };

            var expected = 5;

            var result = MaxTurbulenceSize(arr);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MaxTurbulenceSize(int[] arr)
        {
            var n = arr.Length;
            var result = 1;
            var cur = new int[] { 1, 1 };
            for (int i = 1; i < n; ++i)
            {
                if (i % 2 == 0)
                {
                    if (arr[i] < arr[i - 1])
                    {
                        cur[0]++;
                        cur[1] = 1;
                    }
                    else if (arr[i] > arr[i - 1])
                    {
                        cur[0] = 1;
                        cur[1]++;
                    }
                    else
                    {
                        cur[0] = 1;
                        cur[1] = 1;
                    }
                }
                else
                {
                    if (arr[i] < arr[i - 1])
                    {
                        cur[0] = 1;
                        cur[1]++;
                    }
                    else if (arr[i] > arr[i - 1])
                    {
                        cur[0]++;
                        cur[1] = 1;
                    }
                    else
                    {
                        cur[0] = 1;
                        cur[1] = 1;
                    }
                }
                result = Math.Max(result, Math.Max(cur[0], cur[1]));
            }

            return result;
        }
    }
}
