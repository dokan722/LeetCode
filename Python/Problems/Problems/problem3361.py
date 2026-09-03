import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem3361(Problem):
    def test(self) -> bool:
        s = "abab"
        t = "baba"
        nextCost = [100, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0]
        previousCost = [1, 100, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0]

        expected = 2

        result = self.shiftDistance(s, t, nextCost, previousCost)

        print(result)

        return result == expected

    def shiftDistance(self, s: str, t: str, nextCost: List[int], previousCost: List[int]) -> int:
        result = 0
        forw = [0] * 27
        backw = [0] * 27
        for i in range(26):
            forw[i + 1] = nextCost[i] + forw[i]
            backw[i + 1] = previousCost[25 - i] + backw[i]
        n = len(s)
        for i in range(n):
            x = ord(s[i]) - ord('a')
            y = ord(t[i]) - ord('a')
            f = (forw[y] - forw[x] if x < y else forw[26] - forw[x] + forw[y])
            b = (backw[26] - backw[25 - x] + backw[25 - y] if x < y else backw[25 - y] - backw[25 - x])
            result += min(f, b)

        return result