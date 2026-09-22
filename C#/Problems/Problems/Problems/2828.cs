using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2828 : IProblem
    {
        public bool Test()
        {
            var words = new[] { "alice", "bob", "charlie" };
            var s = "abc";

            var expected = true;
            
            var result = IsAcronym(words, s);

            return expected == result;
        }

        public bool IsAcronym(IList<string> words, string s)
        {
            var n = words.Count;
            var m = s.Length;
            if (n != m)
                return false;
            for (int i = 0; i < n; ++i)
            {
                if (words[i][0] != s[i])
                    return false;
            }

            return true;
        }
    }
}
