import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem2975(Problem):
    def test(self) -> bool:
        m = 4
        n = 3
        hFences = [2, 3]
        vFences = [2]

        expected = 4

        result = self.maximizeSquareArea(m, n, hFences, vFences)

        print(result)

        return result == expected

    def maximizeSquareArea(self, m: int, n: int, hFences: List[int], vFences: List[int]) -> int:
        hn = len(hFences)
        hDists = {m - 1}
        for i in range(hn):
            for j in range(i + 1, hn):
                hDists.add(abs(hFences[i] - hFences[j]))
            hDists.add(abs(1 - hFences[i]))
            hDists.add(abs(m - hFences[i]))

        vn = len(vFences)
        vDists = {n - 1}
        for i in range(vn):
            for j in range(i + 1, vn):
                vDists.add(abs(vFences[i] - vFences[j]))
            vDists.add(abs(1 - vFences[i]))
            vDists.add(abs(n - vFences[i]))

        side = 0
        for hDist in hDists:
            if hDist in vDists:
                side = max(side, hDist)

        return -1 if side == 0 else side * side % 1000000007