import heapq
import math
import queue
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter, deque

from .problem import Problem

class Problem2492(Problem):
    def test(self) -> bool:
        n = 4
        roads = [[1, 2, 9], [2, 3, 6], [2, 4, 5], [1, 4, 7]]

        expected = 5

        result = self.minScore(n, roads)

        print(result)

        return result == expected

    def minScore(self, n: int, roads: List[List[int]]) -> int:
        ngs = [[] for _ in range(n)]
        edges = [[] for _ in range(n)]
        for r in roads:
            a = r[0] - 1
            b = r[1] - 1
            ngs[a].append(b)
            edges[a].append(r[2])
            ngs[b].append(a)
            edges[b].append(r[2])
        visited = [False] * n
        queue = deque()
        queue.appendleft(0)
        visited[0] = True
        result = sys.maxsize
        while queue:
            top = queue.pop()
            ct = len(ngs[top])
            for i in range(ct):
                ng = ngs[top][i]
                edge = edges[top][i]
                result = min(result, edge)
                if not visited[ng]:
                    queue.appendleft(ng)
                    visited[ng] = True

        return result