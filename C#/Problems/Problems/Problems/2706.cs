using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2706 : IProblem
    {
        public bool Test()
        {
            var prices = new[] { 1, 2, 2 };
            var money = 3;

            var expected = 0;

            var result = BuyChoco(prices, money);

            Console.WriteLine(result);

            return result == expected;
        }

        public int BuyChoco(int[] prices, int money)
        {
            var m = int.MaxValue;
            var mm = int.MaxValue;
            foreach (var p in prices)
            {
                if (p <= m)
                {
                    mm = m;
                    m = p;
                }
                else if (p < mm)
                    mm = p;
            }

            var rest = money - m - mm;
            return rest >= 0 ? rest : money;
        }
    }
}
