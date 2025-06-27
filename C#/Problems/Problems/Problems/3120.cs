using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3120 : IProblem
    {
        public bool Test()
        {
            var word = "aaAbcBC";

            var expected = 3;

            var reslut = NumberOfSpecialChars(word);

            return expected == reslut;
        }

        public int NumberOfSpecialChars(string word)
        {
            var charDic = new Dictionary<int, Case>();
            for (int i = 0; i < 26; ++i)
                charDic[i] = new Case();

            foreach (var c in word)
            {
                if (char.IsUpper(c))
                    charDic[c - 'A'].Upper = true;
                else
                    charDic[c - 'a'].Lower = true;
            }

            var result = 0;
            foreach (var c in charDic.Values)
                if (c.Upper && c.Lower)
                    result++;

            return result;
        }

        private class Case
        {
            public bool Lower;
            public bool Upper;
        }
    }
}
