using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1138 : IProblem
    {
        public bool Test()
        {
            var target = "leet";

            var expected = "DDR!UURRR!!DDD!";

            var result = AlphabetBoardPath(target);

            Console.WriteLine(result);

            return result == expected;
        }

        public string AlphabetBoardPath(string target)
        {
            var x = 0;
            var y = 0;
            var result = new StringBuilder();
            foreach (var c in target)
            {
                var ti = c - 'a';
                var xt = ti / 5;
                var yt = ti % 5;
                var mv = x - xt;
                var mh = y - yt;
                var vertical = string.Empty;
                var horizontal = string.Empty;
                if (mv > 0)
                    vertical = new string('U', mv);
                else if (mv < 0)
                    vertical = new string('D', Math.Abs(mv));
                if (mh > 0)
                    horizontal = new string('L', mh);
                else if (mh < 0)
                    horizontal = new string('R', Math.Abs(mh));
                if (xt == 5)
                    result.Append(horizontal + vertical);
                else
                    result.Append(vertical + horizontal);
                result.Append('!');
                x = xt;
                y = yt;
            }

            return result.ToString();
        }
    }
}
