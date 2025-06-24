from .problem import Problem

class Problem2685(Problem):
    def test(self):
        n = 6
        edges = [[0, 1], [0, 2], [1, 2], [3, 4], [3, 5]]

        expected = 1

        result = self.countCompleteComponents(n, edges)

        return result == expected

    def countCompleteComponents(self, n, edges):
        fu = FindUnion(n)
        for edge in edges:
            fu.union(edge[0], edge[1])

        counts = {}

        for edge in edges:
            root = fu.find(edge[0])
            if root in counts:
                counts[root] += 1
            else:
                counts[root] = 1

        result = 0

        for i in range(n):
            if fu.find(i) == i:
                if i not in counts:
                    result += 1
                    continue
                verCount = fu.counts[i]
                edgeCount = verCount * (verCount - 1) / 2
                if edgeCount == counts[i]:
                    result += 1

        return result


class FindUnion:
    def __init__(self, n):
        self.vertices = [-1 for _ in range(n)]
        self.counts = [1 for _ in range(n)]

    def find(self, x):
        if self.vertices[x] != -1:
            self.vertices[x] = self.find(self.vertices[x])
            return self.vertices[x]
        return x

    def union(self, x, y):
        root_x = self.find(x)
        root_y = self.find(y)
        if root_x != root_y:
            self.vertices[root_x] = root_y
            self.counts[root_y] += self.counts[root_x]