import heapq
import math
import queue
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter, deque

from .problem import Problem

class Problem3275(Problem):
    def test(self) -> bool:
        queries = [[1, 2], [3, 4], [2, 3], [-3, 0]]
        k = 2

        expected = [-1, 7, 5, 3]

        result = self.resultsArray(queries, k)

        print1DArray(result)

        return expected == result

    def resultsArray(self, queries: List[List[int]], k: int) -> List[int]:
        n = len(queries)
        heap = []
        result = []
        for i in range(n):
            dist = abs(queries[i][0]) + abs(queries[i][1])
            if len(heap) < k:
                heapq.heappush(heap, -dist)
            elif -heap[0] > dist:
                heapq.heappop(heap)
                heapq.heappush(heap, -dist)
            result.append(-heap[0] if len(heap) == k else -1)
        return result