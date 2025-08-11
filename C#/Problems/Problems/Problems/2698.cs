using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2698 : IProblem
    {
        public bool Test()
        {
            var n = 10;

            var expected = 182;

            var result = PunishmentNumber(n);

            Console.WriteLine(result);

            return result == expected;
        }

        private int[] _punishmentNumbers = new[]
        {
            1,
            9,
            10,
            36,
            45,
            55,
            82,
            91,
            99,
            100,
            235,
            297,
            369,
            370,
            379,
            414,
            657,
            675,
            703,
            756,
            792,
            909,
            918,
            945,
            964,
            990,
            991,
            999,
            1000,
            2137
        };

        public int PunishmentNumber(int n)
        {
            var result = 0;
            for (int i = 0; _punishmentNumbers[i] <= n; ++i)
                result += _punishmentNumbers[i] * _punishmentNumbers[i];

            return result;
        }


        bool IsPunishment(int n, int num)
        {
            if (num < 0 || n < num)
                return false;

            if (n == num)
                return true;

            return IsPunishment(n / 10, num - n % 10) || IsPunishment(n / 100, num - n % 100) || IsPunishment(n / 1000, num - n % 1000);
        }
    }
}
