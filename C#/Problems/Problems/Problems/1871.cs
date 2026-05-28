using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1871 : IProblem
    {
        public bool Test()
        {
            var s = "011010";
            var minJump = 2;
            var maxJump = 3;

            var expected = true;

            var result = CanReach(s, minJump, maxJump);

            return result == expected;
        }

        public bool CanReach(string s, int minJump, int maxJump)
        {
            var n = s.Length;
            if (s[n - 1] == '1')
                return false;
            var canJump = new bool[n];
            canJump[0] = true;
            var cur = 0;
            for (int i = minJump; i < n; ++i)
            {
                if (canJump[i - minJump])
                    cur++;
                if (i - maxJump > 0 && canJump[i - maxJump - 1])
                    cur--;
                if (cur > 0 && s[i] == '0')
                    canJump[i] = true;
            }

            return canJump[n - 1];
        }
    }
}
