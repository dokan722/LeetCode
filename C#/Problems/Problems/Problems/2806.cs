using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2806 : IProblem
    {
        public bool Test()
        {
            var purchaseAmount = 9;

            var expected = 90;

            var result = AccountBalanceAfterPurchase(purchaseAmount);

            Console.WriteLine(result);

            return result == expected;
        }

        public int AccountBalanceAfterPurchase(int purchaseAmount)
        {
            return 100 - (purchaseAmount + 5) / 10 * 10;
        }
    }
}
