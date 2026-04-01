using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public static class Utils
    {
        public static void Print1DArray<T>(IEnumerable<T> array, string valueSeparator = ", ")
        {
            Console.WriteLine(string.Join(valueSeparator, array));
        }

        public static void Print2DArray<T>(IEnumerable<IEnumerable<T>> array, string valueSeparator = ", ", string lineSeparator = "\n")
        {
            foreach (var row in array)
            {
                Print1DArray(row, valueSeparator);
                Console.Write(lineSeparator);
            }
        }

        public static bool Compare1DArrays<T>(IEnumerable<T> array1, IEnumerable<T> array2)
        {
            return array1.SequenceEqual(array2);
        }

        public static bool Compare2DArrays<T>(IEnumerable<IEnumerable<T>> array1, IEnumerable<IEnumerable<T>> array2)
        {
            using var e1 = array1.GetEnumerator();
            using var e2 = array2.GetEnumerator();

            while (e1.MoveNext())
            {
                if (!e2.MoveNext()) return
                    false;

                if (!e1.Current.SequenceEqual(e2.Current))
                    return false;
            }

            return !e2.MoveNext();
        }

        public static T GCD<T>(T a, T b) where T : INumber<T>
        {
            while (b != T.Zero)
            {
                T temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }
    }
}
