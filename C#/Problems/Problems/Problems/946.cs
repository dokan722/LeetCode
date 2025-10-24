using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _946 : IProblem
    {
        public bool Test()
        {
            var pushed = new[] { 1, 2, 3, 4, 5 };
            var popped = new[] { 4, 5, 3, 2, 1 };

            var expected = true;

            var result = ValidateStackSequences(pushed, popped);

            return expected == result;
        }

        public bool ValidateStackSequences(int[] pushed, int[] popped)
        {
            var n = pushed.Length;
            var firstPopped = 0;
            var reverseStack = new Stack<int>();
            for (int i = 0; i < n; ++i)
            {
                reverseStack.Push(pushed[i]);
                while (reverseStack.TryPeek(out var val) && val == popped[firstPopped])
                { 
                    reverseStack.Pop();
                    firstPopped++;
                }
            }

            return reverseStack.Count == 0;
        }
    }
}
