using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1394 : IProblem
    {
        public bool Test()
        {
            var arr = new int[] { 2, 2, 3, 4 };

            var expected = 2;

            var result = FindLucky(arr);

            Console.WriteLine(result);

            return result == expected;
        }

        public int FindLucky(int[] arr)
        {
            var dic = new Dictionary<int, int>();

            foreach (var num in arr)
            {
                if (dic.ContainsKey(num))
                    dic[num]++;
                else
                    dic[num] = 1;
            }
            var result = -1;
            foreach (var pair in dic)
            {
                if (pair.Key == pair.Value && pair.Key > result)
                    result = pair.Key;
            }

            return result;
        }
    }
}
