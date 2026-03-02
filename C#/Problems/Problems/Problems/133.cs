using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Problems.Problems
{
    public class _133 : IProblem
    {
        public bool Test()
        {
            var node = new Node(1);

            var newNode = CloneGraph(node);

            return node != newNode && node.val == newNode.val;
        }

        protected class Node
        {
            public int val;
            public IList<Node> neighbors;

            public Node()
            {
                val = 0;
                neighbors = new List<Node>();
            }

            public Node(int _val)
            {
                val = _val;
                neighbors = new List<Node>();
            }

            public Node(int _val, List<Node> _neighbors)
            {
                val = _val;
                neighbors = _neighbors;
            }
        }

        private Node CloneGraph(Node node)
        {
            return CloneGraphRec(node, new Dictionary<int, Node>());
        }

        private Node CloneGraphRec(Node node, Dictionary<int, Node> present)
        {
            if (node == null)
                return null;
            var clone = new Node(node.val);
            present[clone.val] = clone;
            foreach (var neighbor in node.neighbors)
            {
                if (!present.ContainsKey(neighbor.val))
                    CloneGraphRec(neighbor, present);
                clone.neighbors.Add(present[neighbor.val]);
            }

            return clone;
        }
    }
}
