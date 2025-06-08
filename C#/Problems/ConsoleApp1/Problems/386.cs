using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _386 : IProblem
    {
        public bool Test()
        {
            var n = 13;

            var expected = new List<int> { 1, 10, 11, 12, 13, 2, 3, 4, 5, 6, 7, 8, 9 };

            var result = LexicalOrder(n);

            Console.WriteLine(string.Join(",", result));

            return expected.SequenceEqual(result);
        }

        public IList<int> LexicalOrder(int n)
        {
            var result = new List<int>();

            LexicalOrderRec(n, 1, result);
            return result;
        }

        public void LexicalOrderRec(int n, int num, List<int> result)
        {
            if (num > n)
                return;

            result.Add(num);
            LexicalOrderRec(n, num * 10, result);

            if (num % 10 != 9)
                LexicalOrderRec(n, num + 1, result);
        }
    }
}
