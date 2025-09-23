using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _165 : IProblem
    {
        public bool Test()
        {
            var version1 = "1.2";
            var version2 = "1.10";

            var expected = -1;

            var result = CompareVersion(version1, version2);

            Console.WriteLine(result);

            return expected == result;
        }

        public int CompareVersion(string version1, string version2)
        {
            var splitted = new[] { version1.Split('.'), version2.Split('.') };
            var longer = splitted[0].Length > splitted[1].Length ? 0 : 1;
            var shorter = (longer + 1) % 2;
            for (int i = 0; i < splitted[shorter].Length; ++i)
            {
                if (int.Parse(splitted[0][i]) > int.Parse(splitted[1][i]))
                    return 1;
                if (int.Parse(splitted[0][i]) < int.Parse(splitted[1][i]))
                    return -1;
            }
            for (int i = splitted[shorter].Length; i < splitted[longer].Length; ++i)
            {
                if (int.Parse(splitted[longer][i]) != 0)
                    return longer == 1 ? -1 : 1;
            }

            return 0;
        }
    }
}
