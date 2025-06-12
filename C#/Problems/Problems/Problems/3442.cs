using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3442 : IProblem
    {
        public bool Test()
        {
            var n = "aaaaabbc";

            var expected = 3;

            var result = MaxDifference(n);

            Console.WriteLine(result);

            return expected == result;
        }


        public int MaxDifference(string s)
        {
            var charDic = new int[26];
            for (int i = 0; i < 26; ++i)
            {
                charDic[i] = 0;
            }
            foreach (char c in s)
            {
                charDic[c - 'a']++;
            }

            var min = int.MaxValue;
            var max = 0;
            foreach (var count in charDic)
            {
                if (count == 0)
                    continue;
                if (count % 2 == 1 && count > max)
                    max = count;
                else if (count % 2 == 0 && count < min)
                    min = count;
            }


            return max - min;
        }
    }
}
