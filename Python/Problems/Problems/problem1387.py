import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem1387(Problem):
    def test(self) -> bool:
        lo = 7
        hi = 11
        k = 4

        expected = 7

        result = self.getKth(lo, hi, k)

        print(result)

        return result == expected

    def getKth(self, lo: int, hi: int, k: int) -> int:
        if lo == hi:
            return lo
        n = hi - lo + 1
        pows = [-1] * (3 * hi + 1)
        pows[1] = 0
        forResult = []
        for i in range(n):
            num = i + lo
            forResult.append([self.getPower(num, pows), num])

        forResult.sort()

        return forResult[k - 1][1]

    def getPower(self, n: int, pows: List[int]) -> int:
        if n < len(pows) and pows[n] != -1:
            return pows[n]

        return self.getPower(n // 2, pows) + 1 if n % 2 == 0 else self.getPower(3 * n + 1, pows) + 1