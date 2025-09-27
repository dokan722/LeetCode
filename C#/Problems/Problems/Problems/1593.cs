using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1593 : IProblem
    {
        public bool Test()
        {
            var s = "ababccc";

            var expected = 5;

            var result = MaxUniqueSplit(s);

            Console.WriteLine(result);

            return expected == result;
        }

        public int MaxUniqueSplit(string s)
        {
            return SplitFurther(s, "", 0, new HashSet<string>());
        }

        private int SplitFurther(string s, string curr, int index, HashSet<string> present)
        {
            if (index >= s.Length)
            {
                if (string.IsNullOrEmpty(curr))
                    return present.Count;
                if (present.Contains(curr))
                    return -1;
                return present.Count + 1;
            }

            curr += s[index];
            var withInsert = -1;
            if (!present.Contains(curr))
            {
                present.Add(curr);
                withInsert = SplitFurther(s, string.Empty, index + 1, present);
                present.Remove(curr);
            }

            var noInsert = SplitFurther(s, curr, index + 1, present);

            return Math.Max(withInsert, noInsert);
        }
    }
}
