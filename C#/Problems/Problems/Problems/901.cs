using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _901 : IProblem
    {
        public bool Test()
        {
            StockSpanner stockSpanner = new StockSpanner();
            if (stockSpanner.Next(100) != 1)
                return false;
            if (stockSpanner.Next(80) != 1)
                return false;
            if (stockSpanner.Next(60) != 1)
                return false;
            if (stockSpanner.Next(70) != 2)
                return false;
            if (stockSpanner.Next(60) != 1)
                return false;
            if (stockSpanner.Next(75) != 4)
                return false;
            if (stockSpanner.Next(85) != 6)
                return false;

            return true;
        }

        public class StockSpanner
        {
            private Stack<(int Value, int Span)> _spanStack;
            public StockSpanner()
            {
                _spanStack = new Stack<(int Value, int Span)>();
            }

            public int Next(int price)
            {
                var span = 1;
                while (_spanStack.Count > 0 && _spanStack.Peek().Value <= price)
                {
                    var item = _spanStack.Pop();
                    span += item.Span;
                }
                _spanStack.Push((price, span));
                return span;
            }
        }
    }
}
