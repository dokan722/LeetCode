import heapq
import math
import queue
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter, deque

from .problem import Problem

class Problem3310(Problem):
    def test(self) -> bool:
        n = 4
        k = 1
        invocations = [[1, 2], [0, 1], [3, 2]]

        expected = [0, 1, 2, 3]

        result = self.remainingMethods(n, k, invocations)

        print1DArray(result)

        return expected == result

    def remainingMethods(self, n: int, k: int, invocations: List[List[int]]) -> List[int]:
        nig = [[] for _ in range(n)]
        for i in invocations:
            nig[i[0]].append(i[1])
        sus = [False] * n
        q = deque()
        q.append(k)
        while q:
            next = q.popleft()
            sus[next] = True
            for ni in nig[next]:
                if not sus[ni]:
                    q.append(ni)
        result = []
        for i in range(n):
            if sus[i]:
                continue
            for ni in nig[i]:
                if sus[ni]:
                    return [i for i in range(n)]
            result.append(i)

        return result