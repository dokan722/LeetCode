using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = System.Console;

namespace Problems.Problems
{
    public class _1233 : IProblem
    {
        public bool Test()
        {
            var folder = new string[] { "/a", "/a/b", "/c/d", "/c/d/e", "/c/f" };

            var expected = new string[] { "/a", "/c/d", "/c/f" };

            var result = RemoveSubfolders(folder);

            Console.WriteLine(string.Join(",",result));

            return expected.SequenceEqual(result);
        }

        private class FolderTree
        {
            private Dictionary<string, FolderTree> _nodes = new();

            public bool TryAddMainFolder(string folder)
            {
                var parts = folder.Split('/').Skip(1);
                var node = this;
                var prevPresent = false;
                foreach (var part in parts)
                {
                    if (node._nodes.TryGetValue(part, out var nodeNode))
                    {
                        prevPresent = true;
                        node = nodeNode;
                    }
                    else
                    {
                        if (node._nodes.Count == 0 && prevPresent)
                            return false;
                        node._nodes[part] = new FolderTree();
                        node = node._nodes[part];
                        prevPresent = false;
                    }
                }


                return true;
            }
        }

        public IList<string> RemoveSubfolders(string[] folder)
        {
            Array.Sort(folder, (x, y) => x.Length.CompareTo(y.Length));
            var trie = new FolderTree();
            var result = new List<string>();
            foreach (var f in folder)
            {
                if (trie.TryAddMainFolder(f))
                    result.Add(f);
            }
            return result;
        }
    }
}
