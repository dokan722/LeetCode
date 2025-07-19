from typing import List

from .problem import Problem


class FolderTree:
    def __init__(self):
        self.nodes = {}

    def tryAddMainFolder(self, folder: str) -> bool:
        parts = folder.split('/')[1:]
        node = self
        prevPresent = False
        for part in parts:
            if (part in node.nodes):
                prevPresent = True
                node = node.nodes[part]
            else:
                if len(node.nodes) == 0 and prevPresent:
                    return False
                node.nodes[part] = FolderTree()
                node = node.nodes[part]
                prevPresent = False



        return True


class Problem1233(Problem):
    def test(self) -> bool:
        folder = ["/a", "/a/b", "/c/d", "/c/d/e", "/c/f"]

        expected = ["/a", "/c/d", "/c/f"]

        result = self.removeSubfolders(folder)

        print(','.join(result))

        return expected == result

    def removeSubfolders(self, folder: List[str]) -> List[str]:
        folder.sort(key=len)
        trie = FolderTree()
        result = []
        for f in folder:
            if trie.tryAddMainFolder(f):
                result.append(f)
        return result