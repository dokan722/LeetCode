using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public static class Utils
    {
        public static void Print1DArray(object[] array, string valueSeparator = ", ")
        {
            Console.WriteLine(string.Join(valueSeparator, array));
        }

        public static void Print2DArray(object[][] array, string valueSeparator = ", ", string lineSeparator = "\n")
        {
            foreach (var row in array)
            {
                Print1DArray(row, valueSeparator);
                Console.WriteLine(lineSeparator);
            }
        }

        public static bool Compare1DArrays(object[] array1, object[] array2)
        {
            return array1.SequenceEqual(array2);
        }

        public static bool Compare2DArrays(object[][] array1, object[][] array2)
        {
            if (array1.Length != array2.Length)
                return false;
            for (int i = 0; i < array1.Length; i++)
            {
                if (!Compare1DArrays(array1[i], array2[i]))
                    return false;
            }

            return true;
        }
    }
}
