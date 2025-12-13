using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3606 : IProblem
    {
        public bool Test()
        {
            var code = new[] { "SAVE20", "", "PHARMA5", "SAVE@20" };
            var businessLine = new[] { "restaurant", "grocery", "pharmacy", "restaurant" };
            var isActive = new[] { true, true, true, true };

            var expected = new[] { "PHARMA5", "SAVE20" };

            var result = ValidateCoupons(code, businessLine, isActive).ToArray();

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }

        public IList<string> ValidateCoupons(string[] code, string[] businessLine, bool[] isActive)
        {
            var n = code.Length;
            var ids = new List<int>();
            for (int i = 0; i < n; ++i)
            {
                if (!isActive[i] || string.IsNullOrEmpty(code[i]))
                    continue;
                var valid = true;
                foreach (var c in code[i])
                {
                    if (!char.IsDigit(c) && !char.IsAsciiLetter(c) && c != '_')
                    {
                        valid = false;
                        break;
                    }
                }
                if (businessLine[i] != "electronics" && businessLine[i] != "grocery" && businessLine[i] != "pharmacy" && businessLine[i] != "restaurant")
                    valid = false;
                if (valid)
                    ids.Add(i);
            }

            var result = ids.OrderBy(x => businessLine[x]).ThenBy(x => code[x], StringComparer.Ordinal).Select(x => code[x]).ToList();
            return result;
        }
    }
}
