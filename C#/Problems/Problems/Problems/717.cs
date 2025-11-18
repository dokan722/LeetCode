using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _717 : IProblem
    {
        public bool Test()
        {
            var bits = new[] { 1, 1, 1, 0 };

            var expected = false;

            var result = IsOneBitCharacter(bits);

            return result == expected;
        }

        public bool IsOneBitCharacter(int[] bits)
        {
            var n = bits.Length;
            for (int i = 0; i < n; ++i)
            {
                if (bits[i] == 1)
                {
                    if (i == n - 2)
                        return false;
                    i++;
                }
                else
                {
                    if (i == n - 1)
                        return true;
                }
            }

            return true;
        }
    }
}
