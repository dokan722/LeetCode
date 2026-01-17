using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problems.Problems;

namespace Problems.Contests.BiWeekly174
{
    public class _4 : IProblem
    {
        public bool Test()
        {
            var n = 7;
            //var edges = new[] { new[] { 0, 1 }, new[] { 1, 2 }, new[] { 2, 3 }, new[] { 3, 4 }, new[] { 3, 5 }, new[] { 1, 6 } };
            //var start = "0011000";
            //var target = "0010001";
            var edges = new[] { new[] { 0, 1 }, new[] { 1, 2 } };
            var start = "010";
            var target = "100";

            var expected = new[] { 1, 2, 5 };

            var result = MinimumFlips(n, edges, start, target).ToArray();

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }

        protected class Node
        {
            public int ID;
            public int Curr;
            public int Target;
            public List<(int, int)> Edges = new List<(int, int)>();
        }

        private List<int> _result = new();
        private Dictionary<int, Node> _nodes = new Dictionary<int, Node>();

        public IList<int> MinimumFlips(int n, int[][] edges, string start, string target)
        {
            var e = edges.Length;
            var root = new Node { ID = 0, Curr = start[0] == '1' ? 1 : 0, Target = target[0] == '1' ? 1 : 0 };
            _nodes[0] = root;
            for (int i = 0; i < e; ++i)
            {
                var edge = edges[i];
                if (!_nodes.ContainsKey(edge[0]))
                    _nodes.Add(edge[0], new Node { ID = edge[0], Curr = start[edge[0]] == '1' ? 1 : 0, Target = target[edge[0]] == '1' ? 1 : 0 });
                if (!_nodes.ContainsKey(edge[1]))
                    _nodes.Add(edge[1], new Node { ID = edge[1], Curr = start[edge[1]] == '1' ? 1 : 0, Target = target[edge[1]] == '1' ? 1 : 0 });
                _nodes[edge[0]].Edges.Add((edge[1], i));
                _nodes[edge[1]].Edges.Add((edge[0], i));
            }

            foreach (var edge in root.Edges)
            {
                Dfs(_nodes[edge.Item1], 0, edge.Item2);
            }

            if (root.Curr != root.Target)
                return new[] { -1 };

            return _result.OrderBy(x => x).ToList();
        }

        private void Dfs(Node node, int parent, int pEdge)
        {
             if (node.Edges.Count > 1)
             {
                foreach (var edge in node.Edges)
                {
                    if (edge.Item1 != parent)
                        Dfs(_nodes[edge.Item1], node.ID, edge.Item2);
                }

             }
             if (node.Target != node.Curr)
             {
                 _result.Add(pEdge);
                 _nodes[parent].Curr = (_nodes[parent].Curr + 1) % 2;
             }
        }
    }
}
