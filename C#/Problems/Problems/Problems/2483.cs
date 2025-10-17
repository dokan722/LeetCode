using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2483 : IProblem
    {
        public bool Test()
        {
            var customers = "YYNY";

            var expected = 2;

            var result = BestClosingTime(customers);

            Console.WriteLine(result);

            return result == expected;
        }

        public int BestClosingTime(string customers)
        {
            var n = customers.Length;
            var ys = 0;
            foreach (var c in customers)
                if (c == 'Y')
                    ys++;
            var ns = 0;
            var minPen = ys;
            var result = 0;
            for (int i = 0; i <n; ++i)
            {
                if (customers[i] == 'N')
                    ns++;
                else
                    ys--;
                var pen = ns + ys;
                if (pen < minPen)
                {
                    minPen = pen;
                    result = i + 1;
                }
            }

            return result;
        }
    }
}
