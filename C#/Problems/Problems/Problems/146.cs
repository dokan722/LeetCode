using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _146 : IProblem
    {
        public bool Test()
        {
            LRUCache lRUCache = new LRUCache(2);
            lRUCache.Put(1, 1);
            lRUCache.Put(2, 2);
            if (lRUCache.Get(1) != 1)
                return false;
            lRUCache.Put(3, 3);
            if (lRUCache.Get(2) != -1)
                return false;
            lRUCache.Put(4, 4);
            if (lRUCache.Get(1) != -1)
                return false;
            if (lRUCache.Get(3) != 3)
                return false;
            if (lRUCache.Get(4) != 4)
                return false;

            return true;
        }

        public class LRUCache
        {

            private LinkedList<(int Key, int Val)> _queue;
            private Dictionary<int, LinkedListNode<(int Key, int Val)>> _values;
            private int _capacity;
            public LRUCache(int capacity)
            {
                _queue = new();
                _values = new();
                _capacity = capacity;
            }

            public int Get(int key)
            {
                if (!_values.ContainsKey(key))
                    return -1;
                var node = _values[key];
                _queue.Remove(node);
                _queue.AddFirst(node);
                return node.Value.Val;
            }

            public void Put(int key, int value)
            {
                if (_values.ContainsKey(key))
                {
                    var node = _values[key];
                    _queue.Remove(node);
                    _queue.AddFirst(node);
                    node.Value = (key, value);
                }
                else
                {
                    if (_values.Count >= _capacity)
                    {
                        var toRemove = _queue.Last;
                        _queue.Remove(toRemove);
                        _values.Remove(toRemove.Value.Key);
                        _queue.AddFirst((key, value));
                        _values[key] = _queue.First;
                    }
                    else
                    {
                        _queue.AddFirst((key, value));
                        _values[key] = _queue.First;
                    }
                }
            }
        }
    }
}
