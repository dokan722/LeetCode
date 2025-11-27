using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2469 : IProblem
    {
        public bool Test()
        {
            var celsius = 36.50;

            var expected = new[] { 309.65000, 97.70000 };

            var result = ConvertTemperature(celsius);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(result, expected);
        }

        public double[] ConvertTemperature(double celsius)
        {
            return new[] { celsius + 273.15, celsius * 1.8 + 32 };
        }
    }
}
