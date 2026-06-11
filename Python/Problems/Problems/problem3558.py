import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter, deque

from .problem import Problem


class Problem3558(Problem):
    def test(self) -> bool:
        edges = [[1, 2], [1, 3], [3, 4], [3, 5]]
        expected = 2

        result = self.assignEdgeWeights(edges)

        print(result)

        return result == expected

    def assignEdgeWeights(self, edges: List[List[int]]) -> int:
        n = len(edges) + 1
        nbs = [[] for _ in range(n + 1)]
        for e in edges:
            nbs[e[0]].append(e[1])
            nbs[e[1]].append(e[0])
        d = 0
        q = deque()
        q.append(1)
        q.append(0)
        visited = [False] * (n + 1)
        while len(q) > 1:
            top = q.popleft()
            if top != 0:
                visited[top] = True
                for nb in nbs[top]:
                    if not visited[nb]:
                        q.append(nb)
            else:
                d += 1
                q.append(0)
        res = 1
        b = 2
        mod = 1000000007
        d -= 1
        while (d > 0):
            if d % 2 == 1:
                res = res * b % mod
            b = b * b % mod
            d >>= 1

        return res