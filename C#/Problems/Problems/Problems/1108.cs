using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1108 : IProblem
    {
        public bool Test()
        {
            var address = "1.1.1.1";

            var expected = "1[.]1[.]1[.]1";

            var result = DefangIPaddr(address);

            Console.WriteLine(result);

            return expected == result;
        }

        public string DefangIPaddr(string address)
        {
            return address.Replace(".", "[.]");
        }
    }
}
