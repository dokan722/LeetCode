using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1352 : IProblem
    {
        public bool Test()
        {
            ProductOfNumbers productOfNumbers = new ProductOfNumbers();
            productOfNumbers.Add(3);
            productOfNumbers.Add(0);
            productOfNumbers.Add(2);
            productOfNumbers.Add(5);
            productOfNumbers.Add(4);
            if (productOfNumbers.GetProduct(2) != 20)
                return false;
            if (productOfNumbers.GetProduct(3) != 40)
                return false;
            if (productOfNumbers.GetProduct(4) != 0)
                return false;
            productOfNumbers.Add(8);
            if (productOfNumbers.GetProduct(2) != 32)
                return false;
            return true;
        }

        public class ProductOfNumbers
        {

            private List<int> _preMult;
            public ProductOfNumbers()
            {
                _preMult = new List<int> { 1 };
            }

            public void Add(int num)
            {
                if (num == 0)
                    _preMult = new List<int> { 1 };
                else
                    _preMult.Add(_preMult[_preMult.Count - 1] * num);
            }

            public int GetProduct(int k)
            {
                var n = _preMult.Count;
                if (k >= n)
                    return 0;
                return _preMult[n - 1] / _preMult[n - 1 - k];
            }
        }
    }
}
