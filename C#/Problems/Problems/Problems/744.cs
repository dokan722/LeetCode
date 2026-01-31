using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _744 : IProblem
    {
        public bool Test()
        {
            var letters = new[] { 'c', 'f', 'j'};
            var target = 'c';

            var expected = 'f';

            var result = NextGreatestLetter(letters, target);

            Console.WriteLine(result);

            return result == expected;
        }

        public char NextGreatestLetter(char[] letters, char target)
        {
            var left = 0;
            var right = letters.Length - 1;
            if (letters[right] <= target)
                return letters[0];
            while (left < right)
            {
                var mid = (left + right) / 2;
                if (letters[mid] <= target)
                    left = mid + 1;
                else
                    right = mid;
            }

            return letters[left];
        }
    }
}
